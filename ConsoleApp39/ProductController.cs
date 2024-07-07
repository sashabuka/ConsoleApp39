using ConsoleApp39.Entitties;

public class ProductController
{
    private readonly ProductRepository repository;

    public ProductController(ProductRepository repository)
    {
        this.repository = repository;
    }

    public async Task AddProduct(Product product)
    {
        await this.repository.AddProduct(product.ToDbModel());
    }

    public IEnumerable<Product> GetProducts()
    {
        var dbModel = this.repository.GetProducts()
            .Select(x => x.FromDbModel()).ToList();

        return dbModel;
    }

    public Product? GetProductById(int id)
    {
        var dbModel = this.repository.GetProductById(id);

        return dbModel.FromDbModel();
    }
}
