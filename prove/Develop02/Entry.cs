public class Entry 
{
    public string _date = "";
    public string _prompt = "";
    public string _answer = "";

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date} - Prompt: {_prompt}\n{_answer}");
    }
    
}