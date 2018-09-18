using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Word
  {
    private string _input;
    private string _content;
    private int _count;

    private static List<Word> _instances = new List<Word> {};

    public Word (string input, string content)
    {
      _input = input;
      _content = content;
      _count = 0;
      _instances.Add(this);
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

    public int GetCount()
    {
      return _count;
    }


    public void MatchCheck()
    {
      string[] contentList = SplitContent();

      foreach(string word in contentList)
      {
        if ((word.ToLower()).Equals(_input.ToLower()))
        {
          _count++;
        }
      }
    }

    public string[] SplitContent()
    {
      string[] contentList = _content.Replace(".", " ").Replace("?", " ").Replace("'", " ").Replace("!", " ").Split(' ');
      return contentList;
    }

    public static List<Word> GetAll()
    {
      return _instances;
    }
  }
}
