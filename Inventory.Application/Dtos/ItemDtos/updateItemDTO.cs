using System.ComponentModel.DataAnnotations;

namespace Inventory.Application.ItemDtos
{
    public record updateItemDTO
    {
        [Required]
        public string name { get; set; }
        [Required]
        [Range(1, 100000)]
        public int price { get; set; }

    }
}
