using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CQRS.Resources.Queries;
using CQRS.Models;
using CQRS.Resources.Commands;
using System.ComponentModel.DataAnnotations;

namespace CQRS.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly ISender _mediator;

        public ProductController(ISender mediator)
        {
            _mediator = mediator;
        }

        // GET: ProductController
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                var command = new GetAllProductsQuery();
                var response = await _mediator.Send(command);
                return response is not null ? Ok(response) : NotFound(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: ProductController/Details/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Details([Required] Guid id)
        {

            try
            {
                var command = new GetProductByIdQuery() { Id = id };
                var response = await _mediator.Send(command);
                return response is not null ? Ok(response) : NotFound(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: ProductController/Create
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Product product)
        {
            try
            {
                var command = new CreateProductCommand(product);
                var response = await _mediator.Send(command);
                return response is not null ? Ok(response) : NotFound(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // GET: ProductController/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit([FromBody] Product product)
        {
            try
            {
                var command = new UpdateProductCommand(product);
                var response = await _mediator.Send(command);
                return response is not null ? Ok(response) : NotFound(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: ProductController/Delete/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete([Required]Guid id)
        {
            try
            {
                var command = new DeleteProductCommand() { Id = id };
                var response = await _mediator.Send(command);
                return response is not null ? Ok(response) : NotFound(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
