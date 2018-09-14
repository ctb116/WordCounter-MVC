using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Word
  {
    private string _input;
    private string _content;
    private int _count;
    private int _id;

    private static List<Word> _instances = new List<Word> {};

    public Word (string input, string content)
    {
      _input = input;
      _content = content;
      _count = 0;
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

    public void SetCount(int start)
    {
      _count = start;
    }
    public int GetCount()
    {
      return _count;
    }


    public void MatchCheck(string input)
    {
      string[] contentList = Word.SplitContent(_content);

      int matchCount = 0;
      foreach(string word in contentList)
      {
        if ((word.ToLower()).Equals(input.ToLower()))
        {
          matchCount++;
        }
      }
      _count = matchCount;
    }

    public static string[] SplitContent(string content)
    {
      string[] contentList = content.Replace(".", " ").Replace("?", " ").Replace("'", " ").Replace("!", " ").Split(' ');
      return contentList;
    }

    public static List<Word> GetAll()
    {
      return _instances;
    }

    public int GetId()
    {
      return _id;
    }
    // public void Save()
    // {
    //   _instances.Add(this);
    // }

    public static Word Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
