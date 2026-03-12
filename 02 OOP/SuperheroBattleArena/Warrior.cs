namespace SuperheroBattleArena;

class Warrior : BaseHero
{
    public Warrior(string name, int health, int power) : base(name, health, power)
    {
        
    }
    public override bool Attack(BaseHero attacked)
    {
        Console.WriteLine($"Warrior {_name} is Attacking {attacked.Name}...");
        return !attacked.Attacked(this);
    }
}