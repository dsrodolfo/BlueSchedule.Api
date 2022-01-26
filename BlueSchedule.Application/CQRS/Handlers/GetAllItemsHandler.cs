using AutoMapper;
using BlueSchedule.Application.CQRS.Queries;
using BlueSchedule.Application.Models;
using BlueSchedule.Infrastructure.Interfaces;
using MediatR;

namespace BlueSchedule.Application.Handlers
{
    public class GetAllItemsHandler : IRequestHandler<GetAllItemsQuery, IEnumerable<ItemModel>>
    {
        private readonly IMapper _mapper;
        private readonly IItemRepository _itemRepository;

        public GetAllItemsHandler(IMapper mapper, IItemRepository itemRepository)
        {
            _mapper = mapper;
            _itemRepository = itemRepository;
        }

        public Task<IEnumerable<ItemModel>> Handle(GetAllItemsQuery query, CancellationToken cancellationToken)
        {
            var itemEntities = _itemRepository.GetAllItems();
            var response = _mapper.Map<IEnumerable<ItemModel>>(itemEntities);

            return Task.FromResult(response);
        }
    }
}