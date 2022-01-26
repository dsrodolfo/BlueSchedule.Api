using MediatR;

namespace BlueSchedule.Application.CQRS.Commands
{
    public class UpdateItemCommand : IRequest<int>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Responsible { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}