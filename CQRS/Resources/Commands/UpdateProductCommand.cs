using CQRS.Models;
using MediatR;

namespace CQRS.Resources.Commands
{
    public class UpdateProductCommand : IRequest<Product>
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public bool Active { get; set; } = true;
        public decimal Price { get; set; }

        public UpdateProductCommand(Product product)
        {

            Id = product.Id;
            Name = product.Name;
            Description = product.Description;
            Category = product.Category;
            Active = product.Active;
            Price = product.Price;
        }
    }
}
