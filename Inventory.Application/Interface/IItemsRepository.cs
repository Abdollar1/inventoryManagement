using Inventory.Domain;
using System;
using System.Collections.Generic;

namespace Inventory.Application.Interface
{
    public interface IItemsRpository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();

        void createItem(Item item);

        void updateItem(Item item);

        void deleteItem(Guid id);
    }
}