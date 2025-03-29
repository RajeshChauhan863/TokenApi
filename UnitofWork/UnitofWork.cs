using DAL;
using DAL.Entity;
using Repository;

namespace UnitofWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyDbContext _context;
        private IRepository<Customer> _customerRepository;

        public UnitOfWork(MyDbContext context)
        {
            _context = context;
        }

        public IRepository<Customer> CustomerRepository
        {
            get
            {
                return _customerRepository ??= new CustomerRepository(_context);
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
