using MediatR;

namespace BlueSchedule.Application.CQRS.Commands
{
    public class DeleteItemCommand : IRequest<int>
    {
        public DeleteItemCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}