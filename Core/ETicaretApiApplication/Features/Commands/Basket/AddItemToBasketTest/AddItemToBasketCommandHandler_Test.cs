using ETicaretAPI.Application.Abstractions.Services;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using MediatR;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Commands.Basket.AddItemToBasketTest
{
    public class AddItemToBasketCommandHandler_Test : IRequestHandler<AddItemToBasketCommandRequest_Test, AddItemToBasketCommandResponse_Test>
    {
        //readonly IBasketService _basketService;

        //public AddItemToBasketCommandHandler_Test(IBasketService basketService)
        //{
        //    _basketService = basketService;
        //}
        readonly IBasketItemWriteRepository _basketItemWriteRepository;

        public AddItemToBasketCommandHandler_Test(IBasketItemWriteRepository basketItemWriteRepository)
        {
            _basketItemWriteRepository = basketItemWriteRepository;
        }

        public async Task<AddItemToBasketCommandResponse_Test> Handle(AddItemToBasketCommandRequest_Test request, CancellationToken cancellationToken)
        {
            await _basketItemWriteRepository.AddAsync(new()
            {
                ProductId = Guid.Parse(request.ProductId_Test),
                Quantity = request.Quantity_Test
            });

            await _basketItemWriteRepository.SaveAsync();
            return new();
        }
    }
}