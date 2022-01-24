using BlueSchedule.Application.Models;
using MediatR;

namespace BlueSchedule.Application.CQRS.Queries
{
    public class GetItemByIdQuery : IRequest<ItemModel>
    {
        public GetItemByIdQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}