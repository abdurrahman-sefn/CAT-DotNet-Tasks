namespace SuperheroBattleArena;

abstract class BaseHero
{
    protected string _name;
    protected int _health;
    protected int _power;
    public int Health
    {
        get => _health;
    }
    public int Power
    {
        get => _power;
    }
    public string Name
    {
        get => _name;
    }
    public void Introduce()
    {
        Console.WriteLine($"Hey, Use me I am {_name} the most powerful hero");
    }
    public BaseHero(string name, int health, int power)
    {
        (_name, _health, _power) = (name, health, power);
    }
    public abstract bool Attack(BaseHero attacked);
    public bool Attacked(BaseHero attacker)
    {
        _health -= 30;
        if (_health <= 0)
        {
            Console.WriteLine($"{_name} is dead...");
            return false;
        }
        else
        {
            Console.WriteLine($"{_name}'s health is decreased to {_health}");
            return true;
        }
    }
}