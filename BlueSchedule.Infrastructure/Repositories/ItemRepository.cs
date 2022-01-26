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

        public IEnumerable<ItemEntity> GetAllItems()
        {
            return _context.Item;
        }

        public ItemEntity? GetItemById(Guid id)
        {
            return _context.Item.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}