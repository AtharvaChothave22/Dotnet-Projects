using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;
using Bll;
using BOL;
using DAL;

namespace Portal.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    public IActionResult StudentName()
    {  
        List<Students> sl=StudentManger.GetallStudents();
   
        ViewData["Sfamily"]=sl;
        return View();
    }
     public IActionResult StudentDetails()
    {  
        List<Students> sl=StudentManger.GetallStudDetails();
   
        ViewData["Mfamily"]=sl;
        return View();
    }
      public IActionResult StudentID()
    {  
        List<Students> sl=StudentManger.GetallStudID();
   
        ViewData["Mfamily"]=sl;
        return View();
    }
     public IActionResult Edit()
    {  
       return View();
    }
    [HttpPost]
   public IActionResult Edit(string fname,string lname,int SId)
    {  
        Console.WriteLine("in edit");
        //int tempid=int.Parse(SId);
       DBmanager.Update(fname,lname,SId);
       Console.WriteLine("completed");
       return View();
    }
    public IActionResult Delete()
    {  
       return View();
    }
    [HttpPost]
    public IActionResult Delete(int id){
         Console.WriteLine(id);
         DBmanager.DeleteByid(id);
        //return this.RedirectToAction("Delete");
       return View();

    }
  

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
