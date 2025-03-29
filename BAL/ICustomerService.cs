using DAL.Entity;

namespace BAL
{
    // IProductService.cs
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        void AddCustomer(Customer product);
        void UpdateCustomer(Customer product);
        void DeleteCustomer(int id);
        string UserLogin(string userName, string password);
    }

}
