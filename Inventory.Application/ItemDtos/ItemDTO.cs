﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Application.ItemDtos
{
    public record ItemDto
    {
        public Guid id { get; init; }

        public string name
        {
            get; init;
        }

        public int price
        { get; init; }

        public DateTime createdDate
        { get; init; }

    }

}
