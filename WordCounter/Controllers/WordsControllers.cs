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
      List<Word> allword = Word.GetAll();
      return View(allword);
    }

    [HttpGet("/wordcounter/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/wordcounter/check")]
    public ActionResult Create()
    {
      Word myWord = new Word(Request.Form["new-keyword"], Request.Form["new-content"]);
      myWord.MatchCheck();
      return RedirectToAction("Index");
    }
  }
}
