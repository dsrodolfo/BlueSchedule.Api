using BlueSchedule.Application.CQRS.Commands;
using MediatR;

namespace BlueSchedule.Application.CQRS.Handlers
{
    public class DeleteHandler : IRequestHandler<DeleteItemCommand, int>
    {
        public Task<int> Handle(DeleteItemCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}