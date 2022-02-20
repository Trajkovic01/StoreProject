using InlämningsUppgiftAPI.Models;

namespace InlämningsUppgiftAPI.Services
{
    public interface IProductService
    {
        void Create();
        IEnumerable<Product> Read();
        Product Read(int id);
        void Update();
        void Delete();

    }

    public class ProductService
    {
    }
}
