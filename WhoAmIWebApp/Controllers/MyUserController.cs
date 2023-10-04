using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WhoAmIWebApp.Models;
using WhoAmIWebApp.Services.Interfaces;

namespace WhoAmIWebApp.Controllers
{
    public class MyUserController : Controller

       {

        private readonly IMyUserService _myUserService;



        public MyUserController (IMyUserService myUserService)
        {
            _myUserService = myUserService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public async Task<IActionResult> Create([Bind("Name,Surname,Mail,Password")] MyUser myUser)
        {

          await  _myUserService.Create(myUser);

            return Ok();
        }
    }
}
