using BlueSchedule.Api.CQRS.Commands;
using MediatR;

namespace BlueSchedule.Api.CQRS.Handlers
{
    public class DeleteHandler : IRequestHandler<DeleteItemCommand, int>
    {
        public Task<int> Handle(DeleteItemCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}