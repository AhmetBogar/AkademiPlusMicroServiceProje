using AkademiPlusMicroServiceProje.Discount.Services;
using AkademiPlusMicroServiceProje.Shared.ControllerBases;
using AkademiPlusMicroServiceProje.Shared.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AkademiPlusMicroServiceProje.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : CustomBaseController
    {
        private readonly IDiscountService _discountService;
        private readonly ISharedIdentityService _sharedIdentityService;

        public DiscountController(IDiscountService discountService, ISharedIdentityService sharedIdentityService)
        {
            _discountService = discountService;
            _sharedIdentityService = sharedIdentityService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return CreateActionResultInstance(await _discountService.GetAll());
        }
        public async Task<IActionResult> Save(Models.Discount discount)
        {
            return CreateActionResultInstance(await _discountService.Save(discount));
        }
        [HttpPut]
        public async Task<IActionResult> Update(Models.Discount discount)
        {
            return CreateActionResultInstance(await _discountService.Update(discount));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return CreateActionResultInstance(await _discountService.Delete(id));
        }
        [HttpGet("GetByID")]
        public async Task<IActionResult> GetByID(int id)
        {
            return CreateActionResultInstance(await _discountService.GetByID(id));
        }
    }
}
