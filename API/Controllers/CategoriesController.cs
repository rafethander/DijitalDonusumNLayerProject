using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }




        //GET: api/Categories
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryService.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<CategoryDto>>(categories));
        }

        //GET: api/Categories/id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var category = await _categoryService.GetByIdAsync(id);

            //CategoryDto turunden donucek aldıgı category turunden veriyi.
            return Ok(_mapper.Map<CategoryDto>(category));
        }

        //POST: api/categories
        [HttpPost]
        public async Task<IActionResult> SaveAsync(CategoryDto categoryDto)
        {
            var category = await _categoryService.AddAsync(_mapper.Map<Category>(categoryDto));

            return Created(string.Empty, _mapper.Map<CategoryDto>(category));
        }

        //PUT: api/categories
        [HttpPut]
        public IActionResult Update(CategoryDto categoryDto)
        {
            var category = _categoryService.Update(_mapper.Map<Category>(categoryDto));

            return NoContent();
        }

        //DELETE: api/categories/id
        [HttpDelete("{id}")]
        public IActionResult Remove(Guid id)
        {
            var category = _categoryService.GetByIdAsync(id).Result;
            _categoryService.Remove(category);

            return NoContent();
        }


        //GET: api/categories/id/products
        [HttpGet("{id}/products")]
        public async Task<IActionResult> GetWithProductById(Guid id)
        {
            var categoryWithProducts = await _categoryService.GetWithProductByIdAsync(id);

            return Ok(_mapper.Map<CategoryWithProductDto>(categoryWithProducts));
            
        }

    }
}
