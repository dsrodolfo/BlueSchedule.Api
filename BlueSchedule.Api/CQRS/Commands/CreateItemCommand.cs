using MediatR;

namespace BlueSchedule.Api.CQRS.Commands
{
    public class CreateItemCommand : IRequest<int>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public bool IsFinished { get; set; }
    }
}