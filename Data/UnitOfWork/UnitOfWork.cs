using Core.Repositories;
using Core.UnitOfWorks;
using Data.Repositories;
using System.Threading.Tasks;

namespace Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private ProductRepository _productRepository; 
        private CategoryRepository _categoryRepository;
        private PersonRepository _personRepository;
        
        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public IProductRepository Product => _productRepository ??= new ProductRepository(_context);

        public ICategoryRepository Category => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);

        public IPersonRepository Person => _personRepository = _personRepository ?? new PersonRepository(_context);

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
