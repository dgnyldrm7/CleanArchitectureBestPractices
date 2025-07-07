namespace CleanArchitecture.Application.Features.Products.Queries.GetAllProducts;
using MediatR;

public class GetAllProductsQueryRequest : IRequest<IList<GetAllProductsQueryResponse>>
{
    // This class can be extended in the future to include parameters for filtering, sorting, or pagination.
    // For now, it serves as a simple request to retrieve all products.
}