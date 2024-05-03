public class Prompt {
    public List<string> _prompts;

    public string GetRandomPrompt() {
        Random rnd = new Random();
        int promptLength = _prompts.Count() - 1;

        string prompt = _prompts[rnd.Next(0, promptLength)];

        return prompt;
    }
}