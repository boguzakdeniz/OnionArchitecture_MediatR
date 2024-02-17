using AutoMapper;
using MediatR;
using ProductApp.Application.Dto;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;

namespace ProductApp.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler(IProductRepository productRepository, IMapper mapper) : IRequestHandler<GetAllProductsQuery, ServiceResponse<IList<ProductViewDto>>>
    {
        public async Task<ServiceResponse<IList<ProductViewDto>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await productRepository.GetAllAsync();

            var viewModel = mapper.Map<List<ProductViewDto>>(products);

            return new ServiceResponse<IList<ProductViewDto>>(viewModel);
        }
    }
}
