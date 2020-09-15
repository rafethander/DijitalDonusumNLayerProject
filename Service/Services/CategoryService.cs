using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        private readonly IRepository<Category> _repository;
        private readonly IUnitOfWork _unitOfWork;
        public CategoryService(IRepository<Category> repository,IUnitOfWork unitOfWork): base(repository,unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public async Task<Category> GetWithProductByIdAsync(Guid categoryId)
        {
            return await _unitOfWork.Category.GetWithProductsById(categoryId);
        }
    }
}
