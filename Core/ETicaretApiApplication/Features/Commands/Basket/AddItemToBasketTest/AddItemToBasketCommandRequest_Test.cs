using MediatR;

namespace ETicaretAPI.Application.Features.Commands.Basket.AddItemToBasketTest
{
    public class AddItemToBasketCommandRequest_Test : IRequest<AddItemToBasketCommandResponse_Test>
    {
        public string ProductId_Test { get; set; }
        public int Quantity_Test { get; set; }

        public Guid ID;
    }
}