## Battle Simulation Output

Here's the terminal output of randomly selecting two heroes where one attacks the other until only one hero remains alive.

```text
Initializing Heroes...
Starting the battle...
Archer ghost is Attacking ahmed...
ahmed's health is decreased to 70
Archer ghost is Attacking ghost...
ghost's health is decreased to 170
Archer ahmed is Attacking ghost...
ghost's health is decreased to 140
Archer hany is Attacking ahmed...
ahmed's health is decreased to 40
Archer ghost is Attacking fathy...
fathy's health is decreased to 70
Archer fathy is Attacking hany...
hany's health is decreased to 70
Archer hany is Attacking ahmed...
ahmed's health is decreased to 10
Archer hany is Attacking hany...
hany's health is decreased to 40
Archer fathy is Attacking ghost...
ghost's health is decreased to 110
Archer ghost is Attacking fathy...
fathy's health is decreased to 40
Archer hany is Attacking ahmed...
ahmed is dead...
Archer hany is Attacking ghost...
ghost's health is decreased to 80
Archer hany is Attacking ghost...
ghost's health is decreased to 50
Archer ghost is Attacking fathy...
fathy's health is decreased to 10
Archer hany is Attacking fathy...
fathy is dead...
Archer hany is Attacking ghost...
ghost's health is decreased to 20
Archer ghost is Attacking ghost...
ghost is dead...
hany is the winner!...
```

## A code snippest

```C#
namespace SuperheroBattleArena;

public class Game
{
    List<BaseHero> _heroes = new();
    void Init()
    {
        Console.WriteLine("Initializing Heroes...");
        _heroes.Add(new Archer("ahmed", 100, 80));
        _heroes.Add(new Archer("fathy", 100, 50));
        _heroes.Add(new Archer("ghost", 200, 200));
        _heroes.Add(new Archer("hany", 100, 90));
    }
    public Game()
    {
        Init();
    }
    public void Run()
    {
        Console.WriteLine("Starting the battle...");
        Random rand = new();
        while(_heroes.Count > 1)
        {
            int attacker = rand.Next() % _heroes.Count;
            int attacked = rand.Next() % _heroes.Count;
            if (_heroes[attacker].Attack(_heroes[attacked]))
            {
                _heroes.RemoveAt(attacked);
            }
        }
        Console.WriteLine($"{_heroes[0].Name} is the winner!...");
    }
}
```