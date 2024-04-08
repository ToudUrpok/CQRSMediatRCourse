using CQRSMediatRCourse.WebApi.Data;
using CQRSMediatRCourse.WebApi.Notifications;
using MediatR;

namespace CQRSMediatRCourse.WebApi.Handlers;

public class CacheInvalidationHandler(FakeDataStore fakeDataStore) : INotificationHandler<ProductAddedNotification>
{
    private readonly FakeDataStore _fakeDataStore = fakeDataStore;

    public async Task Handle(ProductAddedNotification notification, CancellationToken cancellationToken)
    {
        await _fakeDataStore.EventOccured(notification.Product, "Cache Invalidated");
        await Task.CompletedTask;
    }
}
