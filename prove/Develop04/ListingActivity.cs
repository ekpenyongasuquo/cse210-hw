public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    private List<string> _listed = new List<string>();

    public ListingActivity(string name, string description)
        : base(name, description)
    {
    }
    public void StartActivity()
    {
        DisplayStart();
        DisplayPrompt();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        int seconds = GetDuration();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(userInput))
            {
                _listed.Add(userInput);
            }
        }
        DisplayListNumber();
        DisplayEnd();
    }

    private string PromptGenerator()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine(PromptGenerator());
    }

    private void DisplayListNumber()
    {
        Console.WriteLine($"You listed {_listed.Count} items.");
        Thread.Sleep(3000);
    }
}