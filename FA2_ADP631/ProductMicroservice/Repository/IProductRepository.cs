using ProductMicroservice.Models;
using System.Collections.Generic;

namespace ProductMicroservice.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductbyID(int productID);
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productID);
        void Save();
        object GetProductByID(int id);
    }
}
