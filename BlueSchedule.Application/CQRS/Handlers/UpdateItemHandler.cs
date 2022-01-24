using BlueSchedule.Application.CQRS.Commands;
using MediatR;

namespace BlueSchedule.Application.CQRS.Handlers
{
    public class UpdateItemHandler : IRequestHandler<UpdateItemCommand, int>
    {
        public Task<int> Handle(UpdateItemCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}