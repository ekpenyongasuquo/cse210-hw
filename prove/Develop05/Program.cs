
class Program
{
    static void Main(string[] args)
    {
        bool play = true;
        Console.WriteLine("What's your name?: ");
        User user = new User(Console.ReadLine());

        do
        {
            Console.WriteLine($"Points: {user.GetTotalPoints()}");
            string MENU = "\nMenu Options:\n   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit\nSelect any option: ";
            Console.WriteLine(MENU);
            int userOption = int.Parse(Console.ReadLine());
            switch (userOption)
            {
                case 1:
                    user.CreateNewGoal();
                    break;

                case 2:
                    user.DisplayGoals();
                    break;

                case 3:
                    user.Save();
                    break;

                case 4:
                    user.Load();
                    break;

                case 5:
                    user.RecordEvent();
                    break;

                case 6:
                    play = false;
                    break;

                default:
                    Console.WriteLine("That's not an option.");
                    break;

            }
        } while (play);
    }
}