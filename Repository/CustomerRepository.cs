using DAL;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        private readonly MyDbContext _context;

        public CustomerRepository(MyDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            return _context.Customers.Find(id);
        }

        public void Add(Customer entity)
        {
            _context.Customers.Add(entity);
        }

        public void Update(Customer entity)
        {
            _context.Customers.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = _context.Customers.Find(id);
            if (entity != null)
            {
                _context.Customers.Remove(entity);
            }
        }
    }

}
