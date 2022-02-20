using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace InlämningsUppgiftAPI.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class CategoryEntities
    {
        public CategoryEntities()
        {

        }

        public CategoryEntities(ICollection<ProductEntities> products)
        {
            Products = products;
        }

        public CategoryEntities(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public CategoryEntities(int id, string name, ICollection<ProductEntities> products)
        {
            Id = id;
            Name = name;
            Products = products;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<ProductEntities> Products { get; }
    }
}