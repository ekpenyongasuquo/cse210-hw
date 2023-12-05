using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new RunningActivity("15 Mar 2021", 7.7, 40));
        activities.Add(new CyclingActivity("20 Jun 2017", 9.6, 40));
        activities.Add(new Swimming("20 Jun 2023", 96, 40));

        int index = 1;
        foreach (Activity activity in activities)
        {
            Console.WriteLine($"\nACTIVITY N°{index}:\n{activity.GetSummary()}");
            index++;
        }
        Console.WriteLine();
    }
}