using System.Collections.Generic;

public class Video
{
  private string _title;
  private string _author;
  private int _length;
  
  private List<Comment> _comments = new List<Comment>();
  
  public Video (string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;

        _comments = comments;
    }

    public string  GetDisplayText()
    {
        string displayText = $"{_title} by {_author}\nLength: {_length} seconds\n\n";
        displayText += $"Comments ({_comments.Count})\n";

        foreach (Comment comment in _comments)
        {
            displayText += $"- {comment.GetDisplayText()}\n";
        }
        return displayText;
    }
}
