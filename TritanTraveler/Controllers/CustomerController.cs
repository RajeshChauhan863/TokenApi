using BAL;
using DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace TritanTraveler.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerService customerService;

    public    CustomerController(ICustomerService _customerService)
    {
            customerService = _customerService;

    }
        // GET: CustomerController


        // GET: CustomerController/Details/5
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Customer Details(int id)
        {
            var data = customerService.GetCustomerById(id);
            return data;
        }

        // GET: CustomerController/Create
       
        // POST: CustomerController/Create
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public void Create(Customer model)
        {
            try
            {
                customerService.AddCustomer(model);
            }
            catch(Exception ex)
            {
                return;
            }
        }
      

        // POST: CustomerController/Edit/5
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("EditUser")]
        [ValidateAntiForgeryToken]
        public void Edit(int id, Customer model)
        {
            try
            {
                customerService.UpdateCustomer(model);
            }
            catch
            {
                return;
            }
        }

        // GET: CustomerController/Delete/5
        [HttpGet]
        [Route("UserDelete")]
        public string Delete(int id)
        {
            customerService.DeleteCustomer(id);

            return "Deleted Record Successfully";
        }

    }
}
