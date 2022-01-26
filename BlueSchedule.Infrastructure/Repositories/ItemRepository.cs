using BlueSchedule.Domain.Entities;
using BlueSchedule.Infrastructure.Context;
using BlueSchedule.Infrastructure.Interfaces;

namespace BlueSchedule.Infrastructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly BlueScheduleDbContext _context;

        public ItemRepository(BlueScheduleDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ItemEntity> GetAllItens()
        {
            return _context.Item;
        }
    }
}