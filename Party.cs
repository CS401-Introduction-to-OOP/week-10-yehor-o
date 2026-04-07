using System.Collections;

namespace week_10_yehor_o;

public class Party : IEnumerable<Person>
{
    private List<Person> _characters = new List<Person>();

    public void AddPerson(Person p) => _characters.Add(p);

    public IEnumerator<Person> GetEnumerator()
    {
        foreach (var person in _characters)
        {
            yield return person;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }


    public IEnumerable<Person> GetActive()
    {
        foreach (var person in _characters)
        {
            if (person.State == "Active")
            {
                yield return person;
            }
        }
    }
    
    public int CountOfInjured() => _characters.Count(x => x.State == "Injured");

    public IEnumerable<Person> SortByLvl(int lvl)
    {
        return _characters.Where(x => x.Level > lvl);
    }

    public Person? MaxGold()
    {
        return _characters.MaxBy(x => x.Gold);
    }


}