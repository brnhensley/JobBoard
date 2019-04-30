using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class JobOpeningsController : Controller
  {

    [HttpGet("/jobopenings")]
    public ActionResult Index()
    {
      List<JobOpening> allJobOpenings = JobOpening.GetAll();
      return View(allJobOpenings);
    }

    [HttpGet("/jobopenings/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/jobopenings")]
    public ActionResult Create(string title, string description, string name, string address, string phone)
    {
      JobOpening myJobOpening = new JobOpening(title, description, name, address, phone);
      return RedirectToAction("Index");
    }

  }
}
