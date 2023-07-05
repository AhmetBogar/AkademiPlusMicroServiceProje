using AkademiPlusMicroServiceProje.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AkademiPlusMicroServiceProje.Frontend.Models
{
    public interface IIdentityService
    {
        Task<Response<bool>> SignIn(SignInInput signInInput);
    }
}
