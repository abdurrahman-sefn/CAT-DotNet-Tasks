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