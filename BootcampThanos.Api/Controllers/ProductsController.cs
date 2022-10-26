
using BootcampThanos.Application.Contracts.Servicios;
using BootcampThanos.BusinessModels.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootcampThanos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("{code}")]
        [ProducesResponseType(typeof(ProductResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetProductByCode(string code)
        {
            ProductResponse? product = _productService.GetProductByCode(code);

            if (product == null) return NoContent();
            else return Ok(product);
        }
    }
}
