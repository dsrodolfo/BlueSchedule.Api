using BlueSchedule.Application.CQRS.Queries;
using BlueSchedule.Application.Models;
using MediatR;

namespace BlueSchedule.Application.Handlers
{
    public class GetItemByIdHandler : IRequestHandler<GetItemByIdQuery, ItemModel>
    {
        public Task<ItemModel> Handle(GetItemByIdQuery query, CancellationToken cancellationToken)
        {
            var item = new ItemModel
            {
                Id = Guid.NewGuid(),
                Title = "Teste XX",
                Date = DateTime.Now,
                IsFinished = false
            };

            return Task.FromResult(item);
        }
    }
}