using CQRS.Models;
using MediatR;

namespace CQRS.Resources.Commands
{
    public class CreateProductCommand : IRequest<Product>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public bool Active { get; set; } = true;
        public decimal Price { get; set; }

        public CreateProductCommand(Product product)
        {
            Name = product.Name;
            Description = product.Description;
            Category = product.Category;
            Active = product.Active;
            Price = product.Price;
        }
    }
}
