using CQRS.Models;
using MediatR;

namespace CQRS.Resources.Commands
{
    public class DeleteProductCommand : IRequest<Product>
    {
        public Guid Id { get; set; }
    }
}
