using BlueSchedule.Domain.Entities;

namespace BlueSchedule.Infrastructure.Interfaces
{
    public interface IItemRepository
    {
        IEnumerable<ItemEntity> GetAllItens();
    }
}