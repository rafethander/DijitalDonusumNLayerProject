﻿using Core.Models;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private AppDbContext appDbContext { get ; }//=> _context as AppDbContext
        public ProductRepository(AppDbContext context):base(context)
        {

        }
        public async Task<Product> GetWithCategoryByIdAsync(Guid productId)
        {
            return await appDbContext.Products.Include(x => x.Category).SingleOrDefaultAsync(x => x.Id == productId);
        }
    }
}