using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Inventory.Infrastructure.Repository.InMemItemsRepositorys;
using Inventory.Application.Interface;
using Inventory.Domain;
using Inventory.Application.ItemDtos;

namespace Inventory.Api.Controllers
{
    //this gets the basic items
    //or the landing page on the postman or swagger
    [ApiController]
    [Route("items")]

    public class itemController : ControllerBase
    {
        private readonly IItemsRpository repository;


        public itemController(IItemsRpository repository)
        {
            this.repository = repository;
        }


        //items
        [HttpGet]
        public IEnumerable<ItemDto> GetItems()
        {
            var items = repository.GetItems().Select(item => item.AsDto());
            return (IEnumerable<ItemDto>)items;
        }


        //items/id to fetch a specific user items
        [HttpGet("{id}")]
        public ActionResult<ItemDto> GetItem(Guid id)
        {
            var item = repository.GetItem(id);

            if (item is null)
            {
                return NotFound();
            }
            return item.AsDto();
        }

        //posting data into the database
        [HttpPost]
        public ActionResult<ItemDto> createItem(createItemDTO itemDto)
        {
            Item item = new()
            {
                id = Guid.NewGuid(),
                name = itemDto.name,
                price = itemDto.price,
                createdDate = DateTime.Now


            };

            repository.createItem(item);

            return CreatedAtAction(nameof(GetItem), new { item.id }, item.AsDto());

        }

        //updating data into the database
        [HttpPut("{id}")]
        public ActionResult updateItem(Guid id, updateItemDTO itemDto)
        {

            var existingItem = repository.GetItem(id);


            if (existingItem is null)
            {
                return NotFound();

            }

            Item updateItem = existingItem with
            {
                name = itemDto.name,
                price = itemDto.price
            };

            repository.updateItem(updateItem);

            return NoContent();

        }

        //deleting data into the database
        [HttpDelete("{id}")]
        public ActionResult deleteItem(Guid id, ItemDto itemDto)
        {
            var existingItem = repository.GetItem(id);
            if (existingItem is null)
            {
                return NotFound();
            }
            repository.deleteItem(id);

            return NoContent();
        }
    }
}
