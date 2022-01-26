using BlueSchedule.Application.CQRS.Commands;
using BlueSchedule.Application.CQRS.Queries;
using BlueSchedule.Application.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BlueSchedule.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ItemController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("Insert")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Insert([FromBody] CreateItemCommand command)
        {
            var response = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { Id = response }, command);
        }

        [HttpGet]
        [Route("getAll")]
        [ProducesResponseType(typeof(IEnumerable<ItemModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllItemsQuery();
            var response = await _mediator.Send(query);
            IActionResult result = response.Any() ? 
                Ok(response) : 
                NotFound("No items were found.");

            return result;
        }

        [HttpGet]
        [Route("get/{id}")]
        [ProducesResponseType(typeof(ItemModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetItemByIdQuery(id);
            var response = await _mediator.Send(query);
            IActionResult result = response != null ? 
                Ok(response) : 
                NotFound(new GenericModel("Item not found."));

            return result;
        }

        [HttpPut]
        [Route("update")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update([FromBody] UpdateItemCommand command)
        {
            var response = await _mediator.Send(command);
            IActionResult result = response != 0 ? NoContent() : BadRequest();

            return result;
        }

        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command = new DeleteItemCommand(id);
            var response = await _mediator.Send(command);
            IActionResult result = response != 0? NoContent() : NotFound();

            return result;
        }
    }
}