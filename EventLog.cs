namespace week_10_yehor_o;

using System.Collections;

public class EventLog : IEnumerable<Event>
{
    private List<Event> _events = new List<Event>();

    public void AddEvent(Event e) => _events.Add(e);

    public IEnumerator<Event> GetEnumerator()
    {
        foreach (var even in _events)
        {
            yield return even;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerable<Event> CertType(string eventType)
    {
        foreach (var evenT in _events)
        {
            if (evenT.EventType == eventType)
            {
                yield return evenT;
            }
        }
    }
    
    public void OrderBySteps() => _events.OrderBy(x => x.NumbStep);
}