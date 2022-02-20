using System.ComponentModel.DataAnnotations;

namespace InlämningsUppgiftAPI.Models
{
    public class ProductEntities
    {
        public ProductEntities(string name, string description, int price, int categoryId)
        {
            Name = name;
            Description = description;
            Price = price;
            CategoryId = categoryId;
        }

        public ProductEntities(int id, string name, string description, int price, int categoryId)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            CategoryId = categoryId;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public int Price { get; set; }


        public int CategoryId { get; set; }
        public virtual CategoryEntities Category { get; set; }
    }
}
