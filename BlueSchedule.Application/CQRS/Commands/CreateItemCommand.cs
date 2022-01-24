using MediatR;

namespace BlueSchedule.Application.CQRS.Commands
{
    public class CreateItemCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public bool IsFinished { get; set; }
    }
}