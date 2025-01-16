
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    internal class Product
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(126)]
        public string ProductName { get; set; }
        public long Price { get; set; }

    }
}
