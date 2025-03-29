using BAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace TritanTraveler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        ICustomerService customerService;
        public UserController(ICustomerService _customerService)
        {
            this.customerService = _customerService;
        }

        [HttpPost]

        public string Login(string userName,string password)
        {
            var token=this.customerService.UserLogin(userName, password);
            return token;
        }

    }
}
