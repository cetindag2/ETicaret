using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Application.RequestParameters;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Queries.Product.GetAllProduct
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, GetAllProductQueryResponse>
    {
        readonly IProductReadRepository _productReadRepository;
        //readonly ILogger <GetAllProductQueryHandler> logger = null;
        public GetAllProductQueryHandler (IProductReadRepository productReadRepository
            //, ILogger<GetAllProductQueryHandler> _logger
            )
        {
            _productReadRepository = productReadRepository;
            //logger = _logger;
        }
        public async Task<GetAllProductQueryResponse> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            //logger.LogInformation("Get all Products");
            var totalCount = _productReadRepository.GetAll(false).Count();
            var products = _productReadRepository.GetAll(false)
                .Skip(request.Page * request.Size)
                .Take(request.Size).Select(p => new
            {
                p.ID,
                p.Name,
                p.Stock,
                p.Price,
                p.CreateDate,
                p.UpdatedDate,
            }).ToList();
            return new()
            {
               Products=products,
               TotalCount=totalCount
            };
        }
    }
}
