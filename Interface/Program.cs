using System.Diagnostics;
internal class Program
{
    private static void Main(string[] args)
    {
        IDamageable[] damageables = new IDamageable[]
            {
                new Player(100),
                new Wall(1000),
                new Car(500),
            };
        for (int i = 0; i < damageables.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {damageables[i]}");
        }
        CheckValue(damageables);
    }
    static void CheckValue(IDamageable[] damageables)
    {
        int.TryParse(Console.ReadLine(), out int intvalue);
        if (intvalue >= 1 && intvalue <= damageables.Length)
        {
            damageables[intvalue - 1].Damage();
        }
    }
}
class Player : IDamageable
{
    private int _xp;
    public Player(int xp)
    {
        _xp = xp;
    }
    public void Damage()
    {
        Console.WriteLine("count damage: ");
        int.TryParse(Console.ReadLine(), out int xp);
        if ((_xp -= xp) > 0)
        {
            Console.WriteLine($"ваш уровень здоровья: {_xp}");
        }
        else
        {
            Console.WriteLine($"ваш уровень здоровья: {_xp = 0}");
        }
    }
}
class Wall : IDamageable
{
    private int _xp;
    public Wall(int xp)
    {
        _xp = xp;
    }
    public void Damage()
    {
        Console.WriteLine("count damage: ");
        int.TryParse(Console.ReadLine(), out int xp);
        if ((_xp -= xp) > 0)
        {
            Console.WriteLine($"ваш уровень здоровья: {_xp}");
        }
        else
        {
            Console.WriteLine($"ваш уровень здоровья: {_xp = 0}");
        }
    }
}
class Car : IDamageable
{
    private int _xp;
    public Car(int xp)
    {
        _xp = xp;
    }
    public void Damage()
    {
        Console.WriteLine("count damage: ");
        int.TryParse(Console.ReadLine(), out int xp);
        if ((_xp -= xp) > 0)
        {
            Console.WriteLine($"ваш уровень здоровья: {_xp}");
        }
        else
        {
            Console.WriteLine($"ваш уровень здоровья: {_xp = 0}");
        }
    }
}
public interface IDamageable
{
    public void Damage();
}