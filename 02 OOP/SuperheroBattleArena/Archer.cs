namespace SuperheroBattleArena;

class Archer : BaseHero
{
    public Archer(string name, int health, int power) : base(name, health, power)
    {
        
    }
    public override bool Attack(BaseHero attacked)
    {
        Console.WriteLine($"Archer {_name} is Attacking {attacked.Name}...");
        return !attacked.Attacked(this);
    }
} 