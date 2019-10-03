using System.Net.Sockets;
using System.Diagnostics.Tracing;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Domain;
using Application.Users;

namespace API.Controllers
{
    public class UserController : BaseController
    {
        [HttpPost("login")]
        public async Task<ActionResult<User>> Login(Login.Query query) 
            => await Mediator.Send(query);
        
    }
}