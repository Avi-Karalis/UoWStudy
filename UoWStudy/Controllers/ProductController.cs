using Microsoft.AspNetCore.Mvc;
using UoWStudy.Core.Models;
using UoWStudy.Services.Interfaces;
namespace UoWStudy.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase {
        //we inject the product Service to the controller. O.O so many injections
        public readonly IProductService _productService;
        public ProductController(IProductService productService) => _productService = productService;

        //Now we start defining the controller via the Service>UnitOfWork>Repo and back again.

        [HttpGet]
        public async Task<IActionResult> GetProductList() {
            var productList = await _productService.GetAll();
            if (productList == null) {
                return NotFound();
            }
            return Ok(productList);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id) {
            var product = await _productService.GetById(id);
            if (product != null) {
                return Ok(product);
            }
            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product) {
            var isCreated = await _productService.CreateProduct(product);
            if (isCreated) {
                return(Ok(isCreated));
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct (Product product) {
            if (product != null) {
                var isUpdated = await _productService.UpdateProduct(product);
                if (isUpdated) {
                    return (Ok(isUpdated));
                }
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct (int id) {

            var isDeleted = await _productService.DeleteProduct(id);
            if (isDeleted) {
                return(Ok(isDeleted));
            }
            return BadRequest();
        }
    }
}