using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Product> _repository;
        public ProductService(IUnitOfWork unitOfWork,IRepository<Product> repository):base(repository,unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }


       
        public Task<Product> GetWithCategoryByIdAsync(Guid productId)
        {
            return _unitOfWork.Product.GetWithCategoryByIdAsync(productId);
        }
    }
}
