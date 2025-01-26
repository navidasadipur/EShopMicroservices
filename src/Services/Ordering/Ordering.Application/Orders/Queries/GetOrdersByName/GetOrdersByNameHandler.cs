using Ordering.Application.Extensions;

namespace Ordering.Application.Orders.Queries.GetOrdersByName;
public class GetOrdersByNameHandler(IApplicationDbContext dbContext)
    : IQueryHandler<GetOrdersByNameQuery, GetOrdersByNameResult>
{
    public async Task<GetOrdersByNameResult> Handle(GetOrdersByNameQuery query, CancellationToken cancellationToken)
    {
        // get orders by name using dbContext
        // return result

        var orders = await dbContext.Orders
            //.Include(o => o.OrderItems)
            .AsNoTracking()
            .Where(o => o.OrderName.Value.Contains(query.Name))
            .OrderBy(o => o.OrderName.Value)
            .ToListAsync(cancellationToken);


        //var orderIds = await dbContext.Orders
        //    .Where(o => EF.Functions.Like(o.OrderName.Value, $"%{query.Name}"))
        //    .Select(o => o.Id)
        //    .ToListAsync(cancellationToken);

        //var orders = await dbContext.Orders
        //    .Where(o => orderIds.Contains(o.Id))
        //    .Include(o => o.OrderItems)
        //    .ToListAsync(cancellationToken);

        return new GetOrdersByNameResult(orders.ToOrderDtoList());
    }
}
