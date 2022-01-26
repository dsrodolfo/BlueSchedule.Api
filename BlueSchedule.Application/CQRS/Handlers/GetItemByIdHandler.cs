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
                Title = "Test YYYYYYYYYYYYY",
                Description = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                Responsible = "Rodolfo",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(7)
            };

            return Task.FromResult(item);
        }
    }
}