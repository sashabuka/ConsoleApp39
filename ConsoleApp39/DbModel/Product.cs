// See https://aka.ms/new-console-template for more information



namespace ConsoleApp39.DbModel;




public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime? Created { get; set; }
}
