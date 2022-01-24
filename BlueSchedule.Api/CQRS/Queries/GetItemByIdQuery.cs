using BlueSchedule.Api.Models;
using MediatR;

namespace BlueSchedule.Api.CQRS.Queries
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