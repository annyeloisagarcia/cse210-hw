public class PromptGenerator
{
    private List<string> prompts;

    public PromptGenerator()
    {
        prompts = new List<string>
        {
            "What was the best part of your day?",
            "What did you learn today?",
            "What are you grateful for?",
            "What challenges did you face today?",
            "What made you smile today?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
