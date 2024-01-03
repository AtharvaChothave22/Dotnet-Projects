using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;
using DAL;
using BOL;
namespace Portal.Controllers;

public class LoginController : Controller
{
    private readonly ILogger<LoginController> _logger;

    public LoginController(ILogger<LoginController> logger)
    {
        _logger = logger;
    }

    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
     public IActionResult Login(string password,string email)
    {   bool status;
        status=DBmanager.ValidateUser(password,email);
       if(status)
        {
        return this.RedirectToAction("User");
        }
        else
        Console.WriteLine("Wrong user");
       
       return View();
    }

   public IActionResult User()
   {
    return View();
   }
    public IActionResult Register()
    {
        return View();
    }
     [HttpPost]
     public IActionResult Register(string Name ,string email )
    {   
        DBmanager.AddStudent(Name,email);
       return this.RedirectToAction("Thank");
        return View();
    }
     public IActionResult Thank()
    {   //return this.RedirectToAction("Login");
        return View();
    }
    [HttpPost]
     public IActionResult Thank(string btn)
    {   return this.RedirectToAction("Login");
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
