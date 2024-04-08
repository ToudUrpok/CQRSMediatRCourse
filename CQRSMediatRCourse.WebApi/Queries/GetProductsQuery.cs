using CQRSMediatRCourse.WebApi.Data.Entities;
using MediatR;

namespace CQRSMediatRCourse.WebApi.Queries;

public record GetProductsQuery() : IRequest<IEnumerable<Product>>;
