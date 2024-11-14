using BaseProject.Dtos.Car;
using BaseProject.Dtos.Shop;
using BaseProject.Helpers;

namespace BaseProject.Services.Interfaces
{
    public interface IShopService
    {
        Task<ServiceResponse> AddShopAsync(AddShopInputDto input);
    }
}
