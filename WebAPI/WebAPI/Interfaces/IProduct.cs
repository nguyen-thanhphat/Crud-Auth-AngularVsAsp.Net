using WebAPI.Model;

namespace WebAPI.Interfaces
{
    public interface IProduct
    {
        ICollection<Product> GetProducts();
        bool CreateProduct(Product product);
        bool UpdateProduct(Product product);
        bool DeleteProduct(Product product);

        bool Save();
    }
}
