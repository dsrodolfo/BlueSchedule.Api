using BlueSchedule.Application.CQRS.Commands;
using MediatR;

namespace BlueSchedule.Application.Handlers
{
    public class CreateItemHandler : IRequestHandler<CreateItemCommand, Guid>
    {
        public Task<Guid> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}