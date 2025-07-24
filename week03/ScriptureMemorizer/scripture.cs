using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rnd = new Random();
        int hiddenCount = 0;
        int attempts = 0;

        while (hiddenCount < numberToHide && attempts < _words.Count * 2)
        {
            int index = rnd.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
            attempts++;
        }
    }

    public string GetDisplayText()
    {
        string display = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            display += word.GetDisplayText() + " ";
        }
        return display.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}
