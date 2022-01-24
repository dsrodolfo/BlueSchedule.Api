using MediatR;

namespace BlueSchedule.Api.CQRS.Commands
{
    public class DeleteItemCommand : IRequest<int>
    {
        public Guid Id { get; set; }
    }
}