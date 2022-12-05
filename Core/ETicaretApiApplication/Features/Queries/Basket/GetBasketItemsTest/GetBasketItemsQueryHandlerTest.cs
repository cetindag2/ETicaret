//using ETicaretAPI.Application.Abstractions.Services;
//using ETicaretAPI.Application.Features.Queries.Basket.GetBasketItems;
//using ETicaretAPI.Application.Repositories;
//using ETicaretAPI.Domain.Entities;
//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ETicaretAPI.Application.Features.Queries.Basket.GetBasketItemsTest
//{
//    public class GetBasketItemsQueryHandlerTest : IRequestHandler<GetBasketItemsQueryRequestTest, List<GetBasketItemsQueryResponseTest>>
//    {
//        readonly IBasketItemReadRepository _basketItemReadRepository;

//        public GetBasketItemsQueryHandlerTest(IBasketItemReadRepository basketItemReadRepository)
//        {
//            _basketItemReadRepository = basketItemReadRepository;
//        }
//        public async Task<List<GetBasketItemsQueryResponseTest>> Handle()
//        {

//            var basketItemsTest = _basketItemReadRepository.GetAll(false).Count();
//            return basketItemsTest.Select(ba => new GetBasketItemsQueryResponseTest
//            {
//                BasketItemId = ba.ID.ToString(),
//                Name = ba.Product.Name,
//                Price = ba.Product.Price,
//                Quantity = ba.Quantity
//            }).ToList();
//            return basketItemsTest;

//            return new()
//            {
//                BasketItemsTests = basketItemsTest
//            };
//        }
//    }
//}
