namespace BlazorEcommerce.Client.Service.CategoryService
{
    public interface ICategorySerice
    {
        List<Category> Categories { get; set; }
        Task GetCategories();
    }
}
