public class Word
{
    private string _text;

    private bool _ishidden;

    public Word (string text)
    {
      _text = text;  
    }

    public void Hide()
    {
        
    }

    public void Show()
    {
        
    }

    public bool IsHidden()
    {
        return true;
    }

    public string GetDisplayText()
    {
        return _text;
    }
}