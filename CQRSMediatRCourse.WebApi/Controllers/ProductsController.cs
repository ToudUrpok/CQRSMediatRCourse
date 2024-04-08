using CQRSMediatRCourse.WebApi.Commands;
using CQRSMediatRCourse.WebApi.Data.Entities;
using CQRSMediatRCourse.WebApi.Notifications;
using CQRSMediatRCourse.WebApi.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSMediatRCourse.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    public async Task<ActionResult> GetProducts()
    {
        var products = await _mediator.Send(new GetProductsQuery());

        return Ok(products);
    }

    [HttpGet("{id:int}", Name = nameof(GetProductById))]
    public async Task<ActionResult> GetProductById(int id)
    {
        var product = await _mediator.Send(new GetProductByIdQuery(id));

        return Ok(product);
    }

    [HttpPost]
    public async Task<ActionResult> AddProduct([FromBody] Product product)
    {
        var productToReturn = await _mediator.Send(new AddProductCommand(product));

        await _mediator.Publish(new ProductAddedNotification(productToReturn));

        return CreatedAtRoute(nameof(GetProductById), new { id = productToReturn.Id }, productToReturn);
    }
}