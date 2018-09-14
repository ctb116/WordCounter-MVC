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

    [HttpPost("/wordcounter")]
    public ActionResult Create()
    {
      Word myword = new Word(Request.Form["new-keyword"], Request.Form["new-content"]);
      List<Word> allword = Word.GetAll();
      return View("Index", allword);
    }

    [HttpGet("/wordcounter/{id}")]
    public ActionResult Details(int id)
    {
      Word keyword = Word.Find(id);
      return View(keyword);
    }

    [HttpPost("/wordcounter/{id}/count")]
    public ActionResult Count(int id)
    {
      List<Word> allword = Word.GetAll();
      int find = id - 1;
      allword[find].test();
      return View("Details", allword[find]);
    }
  }
}
