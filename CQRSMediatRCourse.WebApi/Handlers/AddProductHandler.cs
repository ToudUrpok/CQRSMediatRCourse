using CQRSMediatRCourse.WebApi.Commands;
using CQRSMediatRCourse.WebApi.Data;
using CQRSMediatRCourse.WebApi.Data.Entities;
using MediatR;

namespace CQRSMediatRCourse.WebApi.Handlers;

public class AddProductHandler(FakeDataStore fakeDataStore) : IRequestHandler<AddProductCommand, Product>
{
    private readonly FakeDataStore _fakeDataStore = fakeDataStore;

    public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
    {
        await _fakeDataStore.AddProduct(request.Product);

        return request.Product;
    }
}
