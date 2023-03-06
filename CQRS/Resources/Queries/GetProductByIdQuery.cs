using CQRS.Models;
using MediatR;

namespace CQRS.Resources.Queries
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public Guid Id { get; set; }
    }
}
