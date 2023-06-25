
public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public void HideWord()
    {
        _hidden = true;    
    }

    public void ShowWord()
    {
        _hidden = false;
    }

    public string DisplayText()
    {
        return $"{_word}";
    }
    public bool IsHidden()
        {
            return _hidden;
        }
}