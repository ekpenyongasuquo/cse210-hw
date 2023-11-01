public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private List<string> _questions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public ReflectingActivity(string name, string description) : base (name, description)
    {
    }
    public void StartActivity()
    {
        DisplayStart();
        Console.WriteLine($"---- {PromptGenerator()} ----");
        DisplayQuestion();
        DisplayEnd();
    }
    private string PromptGenerator()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    private string QuestionGenerator()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
    private void DisplayQuestion()
    {
        int seconds = GetDuration();
        while (seconds > 0)
        {
            string question = QuestionGenerator();
            Console.WriteLine(question);
            Countdown();
            seconds -= 3;
        }
    }
    
}