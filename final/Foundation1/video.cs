using System;
using System.Collections.Generic;

class Video
{
  public string _title;
  public string _author;
  public int _length; // in seconds
  private List<Comment> comments;

  public Video(string title, string author, int length)
  {
    _title = title;
    _author = author;
    _length = length;
    comments = new List<Comment>();

  }

  public void AddComment(Comment comment)
  {
    comments.Add(comment);
  }

  public int CommentCount()
  {
    return comments.Count;
  }

  public void Display()
  {
    Console.WriteLine($"Title: {_title}");
    Console.WriteLine($"Author: {_author}");
    Console.WriteLine($"Length: {_length} seconds");
    Console.WriteLine($"Number of comments: {CommentCount()}");
    Console.WriteLine("Comments:");
    foreach (var comment in comments)
    {
      Console.WriteLine($" - {comment}");
    }
    Console.WriteLine (new string('-', 40));
  }
}


