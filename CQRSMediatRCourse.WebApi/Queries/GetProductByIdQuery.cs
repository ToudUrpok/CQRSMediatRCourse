using CQRSMediatRCourse.WebApi.Data.Entities;
using MediatR;

namespace CQRSMediatRCourse.WebApi.Queries;

public record GetProductByIdQuery(int Id) : IRequest<Product>;
