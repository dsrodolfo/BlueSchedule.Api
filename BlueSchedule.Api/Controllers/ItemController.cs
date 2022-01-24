using BlueSchedule.Api.CQRS.Commands;
using BlueSchedule.Api.CQRS.Queries;
using BlueSchedule.Api.Models;
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
        public async Task<IActionResult> Insert([FromBody] CreateItemCommand command)
        {
            var response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpGet]
        [Route("getAll")]
        [ProducesResponseType(typeof(IEnumerable<ItemModel>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetAllItensQuery());

            return Ok(response);
        }

        [HttpGet]
        [Route("get/{id}")]
        [ProducesResponseType(typeof(ItemModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await _mediator.Send(new GetItemByIdQuery(id));
            IActionResult result = response != null ? Ok(response) : NotFound();

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
            var response = await _mediator.Send(new DeleteItemCommand { Id = id });
            IActionResult result = response != 0? NoContent() : NotFound();

            return result;
        }
    }
}