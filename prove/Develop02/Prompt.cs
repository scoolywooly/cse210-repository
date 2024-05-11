public class Prompt {
    private List<string> _prompts = new List<string>();

    public string GetRandomPrompt() {
        Random rnd = new Random();
        int promptLength = _prompts.Count() - 1;

        string prompt = _prompts[rnd.Next(0, promptLength)];

        return prompt;
    }

    public void SetPromptList(string prompt) {
        _prompts.Add(prompt);
    }
}