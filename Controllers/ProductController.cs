using Microsoft.AspNetCore.Mvc;

using poc_training_docker_corenet_backend.Models;
using poc_training_docker_corenet_backend.Services;

namespace poc_training_docker_corenet_backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly ProductService productService;

    public ProductController(ProductService productService) =>
        this.productService = productService;

    [HttpGet]
    public async Task<List<Product>> Get() =>
        await this.productService.GetAsync();

    [HttpGet("{id:length(24)}")]
    public async Task<ActionResult<Product>> Get(string id)
    {
        var product = await this.productService.GetAsync(id);

        if (product is null)
        {
            return NotFound();
        }

        return product;
    }


    [HttpPost]
    public async Task<IActionResult> Post(Product product)
    {
        await this.productService.CreateAsync(product);

        return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
    }

    [HttpPut("{id:length(24)}")]
    public async Task<IActionResult> Update(string id, Product product)
    {
        var _product = await this.productService.GetAsync(id);

        if (_product is null)
        {
            return NotFound();
        }

        product.Id = _product.Id;

        await this.productService.UpdateAsync(id, product);

        return NoContent();
    }


    [HttpDelete("{id:length(24)}")]
    public async Task<IActionResult> Delete(string id)
    {
        var _product = await this.productService.GetAsync(id);

        if (_product is null)
        {
            return NotFound();
        }

        await this.productService.RemoveAsync(id);

        return NoContent();
    }                
}