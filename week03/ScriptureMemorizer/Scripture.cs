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
        Random randomNumber = new Random();
        int hiddenCount = 0;
        
        while (hiddenCount < numberToHide && !isCompletelyHidden())
        {
            int targetedWord = randomNumber.Next(_words.Count);

            if (!_words[targetedWord].IsHidden())
            {
                _words[targetedWord].Hide();
                hiddenCount++;
            }
        }
    }

    public bool isCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
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
}