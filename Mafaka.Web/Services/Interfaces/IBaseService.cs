using Mafaka.Web.Models;

namespace Mafaka.Web.Services.Interfaces
{
    public interface IBaseService : IDisposable
    {
        ResponseDto ResponseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
