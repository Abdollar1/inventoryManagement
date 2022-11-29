using Inventory.Application.ItemDtos;
using Inventory.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Api
{
    public static class Extensions
    {

        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto
            {
                id = item.id,
                name = item.name,
                price = item.price,
                createdDate = item.createdDate,
            };
        }


    }
}
