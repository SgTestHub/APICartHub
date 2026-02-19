using MediatR;
namespace CatalogAPI.Products.CreateProduct
{
    public record CreateProductCommand(
        string Name,
        string Description,
        decimal Price
    ) : IRequest<CreateProductResult>;

    public record CreateProductResult( Guid Id );
    internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            //Business logic to create a product would go here, such as validating the input, saving the product to a database, etc.
            throw new NotImplementedException();
        }
    }
}
