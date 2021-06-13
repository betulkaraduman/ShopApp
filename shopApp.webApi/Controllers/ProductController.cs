using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopApp.business.Abstract;
using shopApp.entity;
using shopApp.webApi.DTO;

namespace shopApp.webApi.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> getProducts()
        {
            var products = await _productService.GetAll();
            var productsDTO = new List<ProductDTO>();
            foreach (var p in products)
            {
                productsDTO.Add(ProductToDTO(p));
            }
            return Ok(productsDTO);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Product(int id)
        {
            var p = await _productService.GetById(id);
            if (p == null)
            {
                return NotFound();
            }
            return Ok(ProductToDTO(p));
        }

        [HttpPost]
        public async Task<IActionResult> NewProduct(Product Entity)
        {
            await _productService.CreateAsync(Entity);
            return CreatedAtAction(nameof(getProducts), new { id = Entity.Id }, ProductToDTO(Entity));
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Product entity)
        {
            if (id != entity.Id)
            {
                Console.WriteLine("hata1");
                return BadRequest();
            }
            var product = await _productService.GetById(id);
            if (product == null)
            {

                Console.WriteLine("hata2");
                return NotFound();
            }
            await _productService.UpdateAsync(product, entity);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            await _productService.DeleteAsync(product);
            return NoContent();
        }

        private static ProductDTO ProductToDTO(Product p)
        {
          return  new ProductDTO
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Description = p.Description,
                ImageUrl = p.ImageUrl,
                Url = p.ProductUrl
            };
        }


    }
}