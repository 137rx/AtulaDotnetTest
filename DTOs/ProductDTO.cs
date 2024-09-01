namespace AtulaDotnetTest.DTOs
{
    public class ProductDTO
    {
        public required int Id { get; set; }
        public required string Sku { get; set; }
        public required string Name { get; set; }

        public ProductDTO(int id, string sku, string name)
        {
            Id = id;
            Sku = sku;
            Name = name;
        }
    }
}