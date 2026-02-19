namespace CatalogAPI.Products.CreateProduct
{
    public record CreateProductCommand(
        string Name,
        string Description,
        decimal Price
    );

    public record CreateProductResult( Guid Id );
    internal class CreateProductCommandHandler
    {

    }
}
