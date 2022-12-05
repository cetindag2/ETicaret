using ETicaretAPI.Application.Features.Commands.Basket.AddItemToBasket;
using ETicaretAPI.Application.Features.Commands.Basket.AddItemToBasketTest;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Repositories;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = "Admin")]
    public class BasketTestController : ControllerBase
    {
        readonly IMediator _mediator;
        readonly IBasketWriteRepository _basketWriteRepository;
        readonly IBasketItemWriteRepository _basketItemWriteRepository;
        readonly IBasketItemReadRepository _basketItemReadRepository;

        public BasketTestController(IMediator mediator, IBasketWriteRepository basketWriteRepository, IBasketItemWriteRepository basketItemWriteRepository, IBasketItemReadRepository basketItemReadRepository)
        {
            _mediator = mediator;
            _basketWriteRepository = basketWriteRepository;
            _basketItemWriteRepository = basketItemWriteRepository;
            _basketItemWriteRepository = basketItemWriteRepository;
            _basketItemReadRepository = basketItemReadRepository;
        }

        //[HttpPost("[action]")]
        //public async Task<IActionResult> AddItemToBasketTest(AddItemToBasketCommandRequest_Test addItemToBasketCommandRequest_Test)
        //{
        //    AddItemToBasketCommandResponse_Test response = await _mediator.Send(addItemToBasketCommandRequest_Test);
        //    return Ok(response);
        //}

        [HttpPost("[action]")]
        public IActionResult BasketCount()
        {
            var basketItemsTest = _basketItemReadRepository.GetAll(false).Count();
            //return basketItemsTest;
            return Content(basketItemsTest.ToString());
        }
    }
}
