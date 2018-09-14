using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Word
  {
    private string _input;
    private string _content;

    public Word (string input, string content)
    {
      _input = input;
      _content = content;
    }
    public string GetInput()
    {
      return _input;
    }
    // public string SetInput(string input)
    // {
    //   _input = input;
    // }
    public string GetContent()
    {
      return _content;
    }
    // public string SetContent(string content)
    // {
    //   _content = content;
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
