
class Program
{
    static void Main(string[] args)
    {
        int breathingLog = 0;
        int reflectingLog = 0;
        int listingLog = 0;

        bool runProgram = true;
        while (runProgram)
        {
            string MENU = "\nMenu options:\n1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Activity Log\n5. Quit";
            Console.WriteLine(MENU);
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathing.StartActivity();
                    breathingLog += 1;
                    break;

                case 2:
                    ReflectingActivity reflecting = new ReflectingActivity("Reflection Exercise", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflecting.StartActivity();
                    reflectingLog += 1;
                    break;

                case 3:
                    ListingActivity listing = new ListingActivity("Listing Exercise", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listing.StartActivity();
                    listingLog += 1;
                    break;

                case 4:
                    Console.WriteLine("Activity - # of times performed in this session");
                    Console.WriteLine($"Breathing Activity: {breathingLog} times");
                    Console.WriteLine($"Reflecting Activity: {reflectingLog} times");
                    Console.WriteLine($"Listing Activity: {listingLog} times");
                    break;

                case 5:
                    Console.WriteLine("Thank you for using the app! :)");
                    runProgram = false;
                    break;

            }
        }

    }

}