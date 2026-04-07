using System.Diagnostics.Contracts;

namespace week_10_yehor_o;


class Program
{
    static void Main(string[] args)
    {
        var eventLog = new EventLog();
        var characters = new Party();

        var character1 = new Person("Sashko", "Sniper", 69, 100, 999, "Active");
        var character2 = new Person("Vasya", "Rusher", 1, 0, 3, "Injured");
        characters.AddPerson(character1);
        characters.AddPerson(character2);
        
        var event1 = new Event(10, "aboba", "Urgent", "Boost HP");
        var event2 = new Event(3, "Boba", "Not Urgent", "Kill");
        eventLog.AddEvent(event1);
        eventLog.AddEvent(event2);
        

        foreach (var x in eventLog)
        {
            Console.WriteLine(x);
        }
        
        Console.WriteLine();
        
        
        
        Console.WriteLine();

        foreach (var e in eventLog.CertType("Urgent"))
        {
            Console.WriteLine(e);
        }
        
        Console.WriteLine();

        foreach (var p in characters.GetActive())
        {
            Console.WriteLine(p);
        }
        
        
        Console.WriteLine();

        Console.WriteLine(characters.CountOfInjured());
        
        Console.WriteLine();

        foreach (var p in characters.SortByLvl(20))
        {
            Console.WriteLine(p);
        }
        
        Console.WriteLine();
        
        Console.WriteLine(characters.MaxGold());
    }
}
