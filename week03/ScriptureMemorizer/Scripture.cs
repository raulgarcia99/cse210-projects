using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    List<Word> _words = new List<Word>();

    public Scripture (Reference reference, string text)
    {
        _reference = reference;

        string[] parts = text.Split(" ");
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        
    }

    public string GetDisplayText()
    {
        string result = "";
        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        return $"{_reference.GetDisplayText()} {result.Trim()}";
    }

    public bool isCompletelyHidden()
    {
        return true;
    }    
}