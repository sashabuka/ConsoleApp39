// See https://aka.ms/new-console-template for more information




using ConsoleApp39.DbModel;

public class ProductRepository
{
    private readonly ProductContext dbContext;

    public ProductRepository(ProductContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task AddProduct(Product product)
    {
        this.dbContext.Products.Add(product);
        await this.dbContext.SaveChangesAsync();
    }

    public IEnumerable<Product> GetProducts()
    {
        return this.dbContext.Products.ToList();
    }

    public Product? GetProductById(int id)
    {
        return this.dbContext.Products.FirstOrDefault(x=>x.Id == id);
    }
}
