using BlueSchedule.Application.Models;
using MediatR;

namespace BlueSchedule.Application.CQRS.Queries
{
    public class GetAllItemsQuery : IRequest<IEnumerable<ItemModel>>
    {

    }
}