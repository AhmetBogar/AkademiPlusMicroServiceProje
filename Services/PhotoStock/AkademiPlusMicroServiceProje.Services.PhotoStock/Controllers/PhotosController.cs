using AkademiPlusMicroServiceProje.Services.PhotoStock.Dtos;
using AkademiPlusMicroServiceProje.Shared.ControllerBases;
using AkademiPlusMicroServiceProje.Shared.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace AkademiPlusMicroServiceProje.Services.PhotoStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotosController : CustomBaseController
    {
        [HttpPost]
        public async Task<IActionResult>PhotoSave(IFormFile photo,CancellationToken cancellationToken)
        {
            if (photo != null&&photo.Length>0)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/photos",photo.FileName);
                using var stream = new FileStream(path, FileMode.Create);
                await photo.CopyToAsync(stream,cancellationToken);
                var returnPath = photo.FileName;
                PhotoDto photoDto = new PhotoDto(){Url = returnPath};
                return CreateActionResultInstance(Response<PhotoDto>.Success(200, photoDto));
            }
            else
            {
                return CreateActionResultInstance(Response<PhotoDto>.Fail("Fotoğraf Bulunamadı.",400));
            }
        }
    }
}
