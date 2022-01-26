using AutoMapper;
using BlueSchedule.Application.Models;
using BlueSchedule.Domain.Entities;

namespace BlueSchedule.Application.Mappings
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<ItemEntity, ItemModel>().ReverseMap();
        }
    }
}