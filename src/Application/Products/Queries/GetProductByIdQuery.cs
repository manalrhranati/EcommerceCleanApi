using MediatR;
using Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Application.Products.Queries;

public class GetProductByIdQuery : IRequest<ProductDto?>
{
    public Guid Id { get; set; }
}

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductDto?>
{
    private readonly IApplicationDbContext _context;

    public GetProductByIdQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<ProductDto?> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var product = await _context.Products
            .Where(x => x.Id == request.Id)
            .Select(x => new ProductDto
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price
            })
            .FirstOrDefaultAsync(cancellationToken);

        return product;
    }
}