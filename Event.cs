namespace week_10_yehor_o;

public class Event
{
    public int NumbStep { get; set; }
    public string Description { get; set; }
    public string EventType { get; set; }
    public string CharChange { get; set; }


    public Event(int numbstep, string description, string eventType, string charChange)
    {
        NumbStep = numbstep;
        Description = description;
        EventType = eventType;
        CharChange = charChange;
    }

    public override string ToString() => $"{NumbStep}, {Description}, {EventType}, {CharChange}";

}