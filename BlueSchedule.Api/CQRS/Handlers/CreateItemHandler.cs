using BlueSchedule.Api.CQRS.Commands;
using MediatR;

namespace BlueSchedule.Api.Handlers
{
    public class CreateItemHandler : IRequestHandler<CreateItemCommand, int>
    {
        public Task<int> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}