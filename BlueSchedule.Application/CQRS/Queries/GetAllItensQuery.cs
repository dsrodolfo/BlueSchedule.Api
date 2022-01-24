using BlueSchedule.Application.Models;
using MediatR;

namespace BlueSchedule.Application.CQRS.Queries
{
    public class GetAllItensQuery : IRequest<IEnumerable<ItemModel>>
    {

    }
}