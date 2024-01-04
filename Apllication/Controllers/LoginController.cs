using BLL;
using BOL;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Apllication.Models;

namespace Apllication.Controllers;

public class LoginController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public LoginController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Login()
    {
        return View();
    }
    public IActionResult Success()
    {
        return View();
    }
     public IActionResult Update()
    {
        return View();
    }
    
    [HttpPost]

     public IActionResult Login(int id ,string fname,string lname)
    {   
        Servicemanager.insert(id,fname,lname);
       // this.Redirectaction("succes");
        return View();
    }

    public IActionResult Edit([FromQuery]int ID )
    {   
        Console.WriteLine(ID);
        ViewData["id"]=ID;
        return View();
    }
    [HttpPost]
    public IActionResult Edit(int id,string fname,string lname)
    {    
       Servicemanager.Edit(id,fname,lname);
        return RedirectToAction("Update");
        return View();
    }
     public IActionResult Delete()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Delete(int id)
    {   
        Servicemanager.Delete(id);
        return RedirectToAction("Success");
        return View();
    }
     public IActionResult Students()
    { 
       List<Atharva> alist= Servicemanager.GetAllStudent();
       ViewData["student"]= alist;
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
