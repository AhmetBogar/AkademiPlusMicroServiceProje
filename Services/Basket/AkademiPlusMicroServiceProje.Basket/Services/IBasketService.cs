using AkademiPlusMicroServiceProje.Basket.Dtos;
using AkademiPlusMicroServiceProje.Shared.Dtos;
using System.Threading.Tasks;

namespace AkademiPlusMicroServiceProje.Basket.Services
{
    public interface IBasketService
    {
        Task<Response<BasketDto>> GetBasket(string UserID);
        Task<Response<bool>> SaveOrUpdate(BasketDto basketDto);
        Task<Response<bool>> Delete(string UserID);
    }
}
