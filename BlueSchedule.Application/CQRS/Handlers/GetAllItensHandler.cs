using BlueSchedule.Application.CQRS.Queries;
using BlueSchedule.Application.Models;
using MediatR;

namespace BlueSchedule.Application.Handlers
{
    public class GetAllItensHandler : IRequestHandler<GetAllItensQuery, IEnumerable<ItemModel>>
    {
        public Task<IEnumerable<ItemModel>> Handle(GetAllItensQuery query, CancellationToken cancellationToken)
        {
            return null;
        }
    }
}