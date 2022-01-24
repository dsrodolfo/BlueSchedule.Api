using BlueSchedule.Api.CQRS.Queries;
using BlueSchedule.Api.Models;
using MediatR;

namespace BlueSchedule.Api.Handlers
{
    public class GetAllItensHandler : IRequestHandler<GetAllItensQuery, IEnumerable<ItemModel>>
    {
        public Task<IEnumerable<ItemModel>> Handle(GetAllItensQuery query, CancellationToken cancellationToken)
        {
            return null;
        }
    }
}