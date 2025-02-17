namespace Catalog.API.Products.GetProductsByCategory
{
    public record GetProductsByCategoryQuery(string Category) : IQuery<GetProductsByCategoryResult>;
    public record GetProductsByCategoryResult(IEnumerable<Product> Products);

    internal class GetProductsByCategoryHandler(IDocumentSession session,ILogger<GetProductsByCategoryHandler> logger) 
        : IQueryHanler<GetProductsByCategoryQuery, GetProductsByCategoryResult>
    {
        public async Task<GetProductsByCategoryResult> Handle(GetProductsByCategoryQuery query, CancellationToken cancellationToken)
        {
            logger.LogInformation("GetProductsByCategoryHandler.Handle called with {@Query}", query);

            var products = await session.Query<Product>()
                .Where(p => p.Category.Contains(query.Category))
                .ToListAsync(cancellationToken);

            return new GetProductsByCategoryResult(products);
        }
    }
}
