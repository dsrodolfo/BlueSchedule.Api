using AutoMapper;
using BlueSchedule.Application.CQRS.Queries;
using BlueSchedule.Application.Models;
using BlueSchedule.Infrastructure.Interfaces;
using MediatR;

namespace BlueSchedule.Application.Handlers
{
    public class GetItemByIdHandler : IRequestHandler<GetItemByIdQuery, ItemModel>
    {
        private readonly IMapper _mapper;
        private readonly IItemRepository _itemRepository;

        public GetItemByIdHandler(IMapper mapper, IItemRepository itemRepository)
        {
            _mapper = mapper;
            _itemRepository = itemRepository;
        }

        public Task<ItemModel> Handle(GetItemByIdQuery query, CancellationToken cancellationToken)
        {
            var itemEntity = _itemRepository.GetItemById(query.Id);
            var response = _mapper.Map<ItemModel>(itemEntity);

            return Task.FromResult(response);
        }
    }
}