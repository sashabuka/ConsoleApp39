namespace ConsoleApp39.Entitties;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime? Created { get; set; }

}


public static class ProductExtensions
{
    public static Product FromDbModel(this DbModel.Product product)
    {
        return new Product()
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
            Created = product.Created
        };
    }

    public static DbModel.Product ToDbModel(this Product product)
    {
        return new DbModel.Product()
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
            Created = product.Created
        };
    }
}
