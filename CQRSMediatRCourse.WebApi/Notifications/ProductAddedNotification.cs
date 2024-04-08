using CQRSMediatRCourse.WebApi.Data.Entities;
using MediatR;

namespace CQRSMediatRCourse.WebApi.Notifications;

public record ProductAddedNotification(Product Product) : INotification;
