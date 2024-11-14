using BaseProject.Dtos.Car;
using BaseProject.Dtos.Shop;
using BaseProject.Helpers.MessageHandler;
using BaseProject.Services;
using BaseProject.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BaseProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShopController(IShopService shopServices, IMessageHandler messageHandler) : BaseController(messageHandler)
    {
       
        public readonly IShopService _shopServices = shopServices;


        [HttpPost]
        public async Task<IActionResult> AddShopAsync([FromBody] AddShopInputDto input)
        {
            return GetServiceResponse(await _shopServices.AddShopAsync(input));
        }

    }



}
