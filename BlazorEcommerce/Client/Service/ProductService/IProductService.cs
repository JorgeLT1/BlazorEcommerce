using BlazorEcommerce.Shared;

namespace BlazorEcommerce.Client.Service.ProductService
{
    public interface IProductService
    {
        event Action ProductsChanged;
        List<Product> Product { get; set; }
        Task GetProducts(string? categoryUrl = null);
        Task<ServiceResponse<Product>> GetProducts(int productId);
    }
}
