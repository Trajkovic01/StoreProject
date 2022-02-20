namespace Inlämnmingsuppgift_ASP.Models.ViewModels
{
    public class ProductModels
    {
        public ProductModels()
        {

        }
        public ProductModels(string name, string description, int price, string categoryName)
        {
            Name = name;
            Description = description;
            Price = price;
            CategoryName = categoryName;
        }

        public ProductModels(int id, string name, string description, int price, string categoryName)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            CategoryName = categoryName;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string CategoryName { get; set; }
    }
}
