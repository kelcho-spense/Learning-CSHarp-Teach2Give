using _8_ProductMS;

namespace _8_ProductStore.Service.Iservices
{
    public interface IProductService
    {
        Task<string> AddProduct(ProductDTO product);
        Task<bool> DeleteProduct(int id);
        Task<ProductModels> GetProductById(int id);
        Task<ProductModels> GetProducts();
        Task<string> UpdateProduct(int id, ProductDTO product);
    }
}