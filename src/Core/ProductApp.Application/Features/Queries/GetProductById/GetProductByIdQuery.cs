using MediatR;
using ProductApp.Application.Wrappers;

namespace ProductApp.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<ServiceResponse<GetProductByIdQueryViewModel>>
    {
        public Guid Id { get; set; }
    }    
}
