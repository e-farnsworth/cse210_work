using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string _randomPrompt;

    public void PopulatePrompts()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What is something that I can do better tomorrow?");
        _prompts.Add("What habbit did you improve on today or want to improve on tomorrow?");
        _prompts.Add("Write about at least three things that you were grateful about today.");
        _prompts.Add("Was there anything that you wished you could have done today? What stoped you?");
        _prompts.Add("What do you love most about yourself?");
    }

    public string RandomPrompt()
    {
        PopulatePrompts();
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(1, _prompts.Count);
        return _prompts[randomIndex - 1];
    }

    
}