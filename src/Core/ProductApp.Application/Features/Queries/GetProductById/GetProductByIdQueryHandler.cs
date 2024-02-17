using AutoMapper;
using MediatR;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;

namespace ProductApp.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQueryHandler(IProductRepository productRepository, IMapper mapper) : IRequestHandler<GetProductByIdQuery, ServiceResponse<GetProductByIdQueryViewModel>>
    {
        public async Task<ServiceResponse<GetProductByIdQueryViewModel>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await productRepository.GetByIdAsync(request.Id);

            var viewModel = mapper.Map<GetProductByIdQueryViewModel>(product);

            return new ServiceResponse<GetProductByIdQueryViewModel>(viewModel);
        }
    }
}
