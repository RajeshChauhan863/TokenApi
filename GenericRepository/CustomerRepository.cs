
using System.Collections.Generic;
using GenericRepository;
using System.Linq;
using DAL;
using Microsoft.EntityFrameworkCore;
namespace GenericRepository
{
    public class CustomerRepository<T> : ICustomerRepository<T> where T : class
    {
        public AppDbContext _context = null;
        public DbSet<T> table = null;

        public CustomerRepository()
        {
            this._context = new AppDbContext();
            table = _context.Set<T>();
        }

        public CustomerRepository(AppDbContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}