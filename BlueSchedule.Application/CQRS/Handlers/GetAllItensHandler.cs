using AutoMapper;
using BlueSchedule.Application.CQRS.Queries;
using BlueSchedule.Application.Models;
using BlueSchedule.Infrastructure.Interfaces;
using MediatR;

namespace BlueSchedule.Application.Handlers
{
    public class GetAllItensHandler : IRequestHandler<GetAllItensQuery, IEnumerable<ItemModel>>
    {
        private readonly IMapper _mapper;
        private readonly IItemRepository _itemRepository;

        public GetAllItensHandler(IMapper mapper, IItemRepository itemRepository)
        {
            _mapper = mapper;
            _itemRepository = itemRepository;
        }

        public Task<IEnumerable<ItemModel>> Handle(GetAllItensQuery query, CancellationToken cancellationToken)
        {
            var itemEntities = _itemRepository.GetAllItens();
            var response = _mapper.Map<IEnumerable<ItemModel>>(itemEntities);

            return Task.FromResult(response);
        }
    }
}