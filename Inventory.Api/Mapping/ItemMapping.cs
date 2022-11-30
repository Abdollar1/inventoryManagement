using AutoMapper;
using Inventory.Application.ItemDtos;
using Inventory.Domain;

namespace Inventory.Api.Mapping
{
    public class ItemMapping:Profile 
    {
        public ItemMapping()
        {
            CreateMap<createItemDTO, Item>();
            CreateMap<ItemDto, Item>();
            CreateMap<updateItemDTO, Item>();
        }
    }
}
