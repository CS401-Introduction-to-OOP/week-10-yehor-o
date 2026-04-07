namespace week_10_yehor_o;

public class Person
{
    public string Name { get; set; }
    public string Role { get; set; }
    public int Level { get; set; }
    public int Health { get; set; }
    public int Gold { get; set; }
    public string State { get; set; }

    public Person(string name, string role, int lvl, int health, int gold, string state)
    {
        Name = name;
        Role = role;
        Level = lvl;
        Health = health;
        Gold = gold;
        State = state;
    }

    public override string ToString() => $"{Name}, {Role}, {Level}, {Health}, {Gold}, {State}";
}