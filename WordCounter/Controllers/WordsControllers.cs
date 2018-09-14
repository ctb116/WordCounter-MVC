using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordsController : Controller
  {

    [HttpGet("/wordcounter")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/wordcounter/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/wordcounter")]
    public ActionResult Create()
    {
      return View("Index");
    }
  }
}
