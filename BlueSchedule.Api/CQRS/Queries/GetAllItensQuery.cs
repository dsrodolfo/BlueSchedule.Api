using BlueSchedule.Api.Models;
using MediatR;

namespace BlueSchedule.Api.CQRS.Queries
{
    public class GetAllItensQuery : IRequest<IEnumerable<ItemModel>>
    {

    }
}