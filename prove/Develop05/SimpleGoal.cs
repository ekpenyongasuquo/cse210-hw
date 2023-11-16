public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool isCompleted) : base (name, description, points, isCompleted)
    {
        _type = 1;
    }
    public override void SetIsCompleted()
    {
        _isCompleted = true;
        Console.WriteLine($"Congratulations! You earned {_points} points");
    }
    public override void DisplayGoal(int option)
    {
        if(option == 0)
        {
            if(GetIsCompleted())
            {
                Console.Write("[X]");
            }
            else
            {
                Console.Write("[ ]");
            }
            Console.WriteLine($" {_name} ({_description})");
        }
        else
        {
            Console.WriteLine($"{_name}");         
        }
    }
    public override string GetStringRep()
    {
        return $"{_type}|{_name}|{_description}|{_points}|{_isCompleted}";
    }
}