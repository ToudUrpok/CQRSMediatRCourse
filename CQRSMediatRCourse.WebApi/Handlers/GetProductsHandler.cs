using CQRSMediatRCourse.WebApi.Data.Entities;
using CQRSMediatRCourse.WebApi.Data;
using CQRSMediatRCourse.WebApi.Queries;
using MediatR;

namespace CQRSMediatRCourse.WebApi.Handlers;

public class GetProductsHandler(FakeDataStore fakeDataStore) : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
{
    private readonly FakeDataStore _fakeDataStore = fakeDataStore;

    public async Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken) =>
        await _fakeDataStore.GetAllProducts();
}
