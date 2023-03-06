using CQRS.Models;
using MediatR;

namespace CQRS.Resources.Queries
{
    public class GetAllProductsQuery : IRequest<IEnumerable<Product>>
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
