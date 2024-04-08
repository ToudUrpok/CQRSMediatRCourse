using CQRSMediatRCourse.WebApi.Data.Entities;
using MediatR;

namespace CQRSMediatRCourse.WebApi.Commands;

public record AddProductCommand(Product Product) : IRequest<Product>;
