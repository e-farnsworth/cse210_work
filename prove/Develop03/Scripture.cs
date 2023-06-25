public class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(string verse, Reference reference)
    {
        _reference = reference;
        _words = new List<Word>();

        List<string> allwords = verse.Split(" ").ToList();
        // Splits the text up by the spaces

        foreach (string wordString in allwords)
        {
            Word word = new Word(wordString);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            Random randomIndex = new Random();
            int index = randomIndex.Next(1, _words.Count);
            if (_words[index].IsHidden() == false)
            {
                _words[index].HideWord();
            }
            else
            {
                i --;
            }
        }
    }

    public string Display()
    {
        string scriptureText = "";

        foreach (Word _word in _words)
        {
            if (_word.IsHidden() == false)
            {
                scriptureText += _word.DisplayText() + " ";
            }
            else
            {
                scriptureText += new string('_',_word.DisplayText().Length) + " ";
            }
        }

        return $"{_reference.DisplayText()} {scriptureText}";
    }

    public bool CompletelyHidden()
    {
        int count = 0;
        foreach (Word _word in _words)
        {
            if (_word.IsHidden() == true)
            {
                count ++;
            }
        }

        if (count == _words.Count)
        {
            Console.WriteLine($"{count}:{_words.Count}");
            return true;
        }
        else
        {
            Console.WriteLine($"{count}:{_words.Count}");
            return false;
        }

    }

}