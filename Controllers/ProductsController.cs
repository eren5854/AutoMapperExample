using AutoMapper;
using AutoMapperExample.Context;
using AutoMapperExample.DTOs;
using AutoMapperExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperExample.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class ProductsController(
    ApplicationDbContext context,
    IMapper mapper) : ControllerBase
{
    [HttpPost]
    public IActionResult Create(CreateProductDto request)
    {
        Product product = mapper.Map<Product>(request);

        context.Add(product);
        context.SaveChanges();
        return Ok(new {message = "Ürün Kaydı Başarılı"});
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var products = context.Products.ToList();
        return Ok(products);
    }

    [HttpPost]
    public IActionResult Update(UpdateProductDto request)
    {
        Product? product = context.Products.Where(p => p.Id == request.Id).FirstOrDefault();
        if (product is null)
        {
            return BadRequest();  
        }

        mapper.Map(request, product);
        context.Update(product);
        context.SaveChanges();

        return Ok(new { message = "Ürün Güncelleme Başarılı" });

    }

    [HttpGet]
    public IActionResult Delete(Guid Id)
    {
        Product? product = context.Products.Where(p => p.Id == Id).FirstOrDefault();
        if (product is null)
        {
            return BadRequest();
        }

        context.Remove(product);
        context.SaveChanges();
        return Ok(new { message = "Ürün Silme Başarılı" });
    }
}
