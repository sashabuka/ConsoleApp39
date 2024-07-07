using ConsoleApp39.Entitties;

Console.WriteLine("Hello, World!");



var dbContext = new ProductContext();
var repository = new ProductRepository(dbContext);

var productController = new ProductController(repository);


var newProduct = new Product() { Name = "Product 1", Description = "test4", Price = 100 };

await productController.AddProduct(newProduct);