using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the best part of my day?",
        "What am I grateful for today?",
        "What's something I learned today?",
        "If I had one thing I could do over today, what would it be?",
        "How can I be a better person tomorrow?"
    };

    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        return _prompts[index];
    }
}