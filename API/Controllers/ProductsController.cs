using API.Dtos;
using API.Filters;
using AutoMapper;
using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductsController:ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IProductService _productService;

        public ProductsController(IMapper mapper,IProductService productService)
        {
            _mapper = mapper;
            _productService = productService;
        }


        //GET: api/Products
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productService.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<ProductDto>>(products));
        }


        //GET: api/products/id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var product = await _productService.GetByIdAsync(id);

            return Ok(_mapper.Map<ProductDto>(product));
        }

        //POST: api/products
        [ValidationFilter]
        [HttpPost]
        public async Task<IActionResult> Save(ProductDto productDto)
        {
            var product = await _productService.AddAsync(_mapper.Map<Product>(productDto));

            return Created(string.Empty,_mapper.Map<ProductDto>(product));
        }


        //PUT: api/product
        [HttpPut]
        public IActionResult Update(ProductDto productDto)
        {
            var product = _productService.Update(_mapper.Map<Product>(productDto));

            return NoContent();
        }

        //DELETE: api/product/id
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var product =_productService.GetByIdAsync(id).Result;
            _productService.Remove(product);

            return NoContent();
        }


        //GET: api/products/id/category
        [HttpGet("{id}/category")]
        public async Task<IActionResult> GetWithCategoryById(Guid id)
        {
            var product = await _productService.GetWithCategoryByIdAsync(id);

            return Ok(_mapper.Map<ProductWithCategoryDto>(product));
        }
    }
}
