public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base (name, description)
    {
    }
    public void StartActivity()
    {
        DisplayStart();
        int seconds = GetDuration();
        bool breatheIn = true;
        while (seconds > 0)
        {
            if (breatheIn)
            {
                Console.WriteLine("Breathe in...");
            }
            else
            {
                Console.WriteLine("Breathe out...");
            }
            Countdown();
            breatheIn = !breatheIn;
            seconds = seconds - 3;
        }
        DisplayEnd();
    }
}