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

// Originally I wanted the MatchCheck() to happen when the user created a wordcounter entry
// I thought to put the MatchCheck() method somewhere in here
// I later put the MatchCheck() method in the wordcounter entry (below) to better follow the Tamagotchi
// example from class. MatchCheck() would trigger giving a word count similar to feeding a Tamagotchi
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

// This HttpPost does not return the user back to their word counter entry.
// Instead it brings up a blank page with the default "welcome!"

    // [HttpPost("/wordcounter/{id}/count")]
    // public ActionResult Count(int id, string input)
    // {
    //   List<Word> allword = Word.GetAll();
    //   int find = id - 1;
    //   allword[find].MatchCheck(input);
    //   return View("Details", allword[find]);
    // }
  }
}
