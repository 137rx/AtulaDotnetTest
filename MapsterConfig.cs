using Mapster;
using AtulaDotnetTest.Models;
using AtulaDotnetTest.DTOs;

public static class MapsterConfig
{
    public static void RegisterMappings()
    {
        TypeAdapterConfig<Product, ProductDTO>.NewConfig();
        TypeAdapterConfig<ProductDTO, Product>.NewConfig();
    }
}