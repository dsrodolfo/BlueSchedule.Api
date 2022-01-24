using BlueSchedule.Api.CQRS.Commands;
using MediatR;

namespace BlueSchedule.Api.CQRS.Handlers
{
    public class UpdateItemHandler : IRequestHandler<UpdateItemCommand, int>
    {
        public Task<int> Handle(UpdateItemCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}