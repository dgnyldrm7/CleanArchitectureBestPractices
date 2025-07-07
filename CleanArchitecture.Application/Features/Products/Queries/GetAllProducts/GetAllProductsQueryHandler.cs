using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Interfaces.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.Products.Queries.GetAllProducts;

public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IProductRepository _productRepository;
    public GetAllProductsQueryHandler(IUnitOfWork unitOfWork, IProductRepository productRepository)
    {
        _unitOfWork = unitOfWork;
        _productRepository = productRepository;
    }
    async Task<IList<GetAllProductsQueryResponse>> IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>.Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
    {
        var products = await _productRepository.GetAllAsync();

        var response = products.Select(p => new GetAllProductsQueryResponse
        {
            Name = p.Name,
            Description = p.Description,            
        }).ToList();

        return response;
    }
}