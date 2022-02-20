namespace InlämningsUppgiftAPI.Models
{
    public class Categories
    {
        public Categories()
        {

        }

        public Categories(string name, string product)
        {
            Name = name;
            Product = product;
        }

        public Categories(int id, string name, string product)
        {
            Id = id;
            Name = name;
            Product = product;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string Product { get; set; }

    }
}
