using System;

class Program
{
    static void Main(string[] args)
    {
        Address[] addresses = new Address[3];
        addresses[0] = new Address("5720 Holy ST", "Denver", "Colorado", "96999-5727", "United States");
        addresses[1] = new Address("9 Saint James PL", "Nashua", "New Hampshire", "0306-4614", "United States");
        addresses[2] = new Address("Lombardy", "Milano", "Mila", "61236", "Italy");

        Event[] events = new Event[3];
        events[0] = new LectureEvent("Introduction to C Programming", "Let's learn the basics of C Programming", "12/09/2023", "12:00pm", addresses[0], "Rebecca", "100 People");
        events[1] = new ReceptionEvent("Isabella Wedding", "Join us celebrating Isabella's Wedding", "12/22/2023", "08:00pm", addresses[1], "isabella@outlook.com");
        events[2] = new OutdoorGatheringEvent("Soccer With Friends", "Let's play 90 minutes of the best soccer with friends!", "12/12/2023", "09:00pm", addresses[2], "Mist");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Event N°: {i + 1}");
            Console.WriteLine("\n-STANDARD DETAILS-");
            Console.WriteLine(events[i].StandardDetails());
            Console.WriteLine("-SHORT DETAILS- ");
            Console.WriteLine(events[i].ShortDetails());
            Console.WriteLine("-FULL DETAILS-");
            Console.WriteLine(events[i].FullDetails());

        }
    }
}