public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStart()
    {
        Console.WriteLine($"Welcome to the: {_name}\n{_description}");
        InputDuration();
        Console.WriteLine($"The {_name} activity will start for {_duration} seconds...");
        Countdown();
    }
    public void DisplayEnd()
    {
        Console.WriteLine($"Great job! You completed {_name} for {_duration} seconds.");
        Thread.Sleep(2500);
        Console.WriteLine();
    }
    public void Countdown()
    {
        for (int i = 3; i > 0; i--)
        {
            Console.Write($"\r{i}...");
            Thread.Sleep(1100);
        }
        Console.WriteLine();
    }
    public void InputDuration()
    {
        Console.WriteLine("Enter the duration of the activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;
    }

    //GETERS
    public int GetDuration()
    {
        return _duration;
    }
}