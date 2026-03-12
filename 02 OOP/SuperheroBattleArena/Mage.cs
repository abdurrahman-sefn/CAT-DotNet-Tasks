namespace SuperheroBattleArena;

class Mage : BaseHero
{
    public Mage(string name, int health, int power) : base(name, health, power)
    {
        
    }
    public override bool Attack(BaseHero attacked)
    {
        Console.WriteLine($"Mage {_name} is Attacking {attacked.Name}...");
        return !attacked.Attacked(this);
    }
} 