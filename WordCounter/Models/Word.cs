using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Word
  {
    private string _input;
    private string _content;
    private int _id;
    private static List<Word> _instances = new List<Word> {};

    public Word (string input, string content)
    {
      _input = input;
      _content = content;
      _instances.Add(this);
      _id = _instances.Count;
    }
    public string GetInput()
    {
      return _input;
    }
    public void SetInput(string keyWord)
    {
      _input = keyWord;
    }
    public string GetContent()
    {
      return _content;
    }
    public void SetContent(string inputContent)
    {
      _content = inputContent;
    }
    public static List<Word> GetAll()
    {
      return _instances;
    }
    public int GetId()
    {
      return _id;
    }
    public static Word Find(int searchId)
    {
      return _instances[searchId-1];
    }
    // public void Save()
    // {
    //   _instances.Add(this);
    // }

    // public int MatchCheck(string input)
    // {
    //   string[] contentList = RepeatCounter.SplitContent(_content);
    //
    //   int matchCount = 0;
    //   foreach(string word in contentList)
    //   {
    //     if ((word.ToLower()).Equals(input.ToLower()))
    //     {
    //     matchCount++;
    //     }
    //   }
    //   return matchCount;
    // }
    //
    // public static string[] SplitContent(string content)
    // {
    //   string[] contentList = content.Replace(".", " ").Replace("?", " ").Replace("'", " ").Replace("!", " ").Split(' ');
    //   return contentList;
    // }
  }
}
