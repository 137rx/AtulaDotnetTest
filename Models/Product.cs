public class Product
{
    public required int Id { get; set; }
    public required string Sku { get; set; }
    public required string Name { get; set; }

      public Product(int id, string sku, string name)
    {
        Id = id;
        Sku = sku;
        Name = name;
    }
}