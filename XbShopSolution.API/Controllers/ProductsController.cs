using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XbShopSolution.Application.Services.IService;
using XbShopSolution.ViewModel.ViewModel.Products;

namespace XbShopSolution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }
        [HttpPost("create-product")]
        public async Task<IActionResult> CreateProduct([FromForm]ProductCreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            var result = await _service.CreateProductAsync(model);
            return Ok(result);
        }
    }
}
