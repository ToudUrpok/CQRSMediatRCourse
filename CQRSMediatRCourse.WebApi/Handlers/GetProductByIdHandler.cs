using CQRSMediatRCourse.WebApi.Data.Entities;
using CQRSMediatRCourse.WebApi.Data;
using CQRSMediatRCourse.WebApi.Queries;
using MediatR;

namespace CQRSMediatRCourse.WebApi.Handlers;

public class GetProductByIdHandler(FakeDataStore fakeDataStore) : IRequestHandler<GetProductByIdQuery, Product>
{
    private readonly FakeDataStore _fakeDataStore = fakeDataStore;

    public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken) =>
        await _fakeDataStore.GetProductById(request.Id);

}
