using System;

public abstract class Car
{
    protected virtual int NumAttacks { get { return 0; } }
    protected virtual int Defense { get { return 0; } }

    public void PrintNumAttacks()
    {
        Console.WriteLine(
            string.Format(" - Has {0} stored moves",
            this.NumAttacks));
    }
    public void printDefense()
    {
        Console.WriteLine(
            string.Format(" - Defense is rated {0}",
            this.Defense));
    }
}

public class Spawn : Car
{
    protected override int NumAttacks { get { return 1; } }
    protected override int Defense { get { return 1; } }
}

public class Octane : Spawn
{
    protected override int NumAttacks { get { return 3; } }
    protected override int Defense { get { return 5; } }
    public virtual void moves()
    {
        Console.WriteLine(String.Format(" - Has {0} stored moves", this.NumAttacks));
    }
    public virtual void block()
    {
        Console.WriteLine(String.Format(" - Defense is rated {0}", this.Defense));
    }
    public void octane()
    {
        Console.WriteLine("Fear me for I am the OG Octane!");
    }
    public void IQ()
    {
        Console.WriteLine(" - IQ is rated at a 10");
    }
    public void Strength()
    {
        Console.WriteLine(" - Strength is rated at a 4");
    }
    public void Speed()
    {
        Console.WriteLine(" - Speed is rated at a 7");
    }
}

public class Fennec : Spawn
{
    protected override int NumAttacks { get { return 4; } }
    protected override int Defense { get { return 2; } }
    public virtual void moves()
    {
        Console.WriteLine(String.Format(" - Has {0} stored moves", this.NumAttacks));
    }
    public virtual void block()
    {
        Console.WriteLine(String.Format(" - Defense is rated {0}", this.Defense));
    }
    public void fennec()
    {
        Console.WriteLine("Hello, I am the new Fennec the best of both of you.");
    }
    public void IQ()
    {
        Console.WriteLine(" - IQ is rated at a 8");
    }
    public void Strength()
    {
        Console.WriteLine(" - Strength is rated at a 7");
    }
    public void Speed()
    {
        Console.WriteLine(" - Speed is rated at a 6");
    }
}

public class Dominus : Spawn
{
    protected override int NumAttacks { get { return 2; } }
    protected override int Defense { get { return 10; } }
    public virtual void moves()
    {
        Console.WriteLine(String.Format(" - Has {0} stored moves", this.NumAttacks));
    }
    public virtual void block()
    {
        Console.WriteLine(String.Format(" - Defense is rated {0}", this.Defense));
    }
    public void dominus()
    {
        Console.WriteLine("I'm dominus the strongest flat car here.");
    }
    public void IQ()
    {
        Console.WriteLine(" - IQ is rated at a 4");
    }
    public void Strength()
    {
        Console.WriteLine(" - Strength is rated at a 10");
    }
    public void Speed()
    {
        Console.WriteLine(" - Speed is rated at a 3");
    }
}

public class Encounter
{
    static void Main(string[] args)
    {
        Octane mob1 = new Octane();
        Console.WriteLine("A wild octane appeared");
        mob1.octane();
        mob1.moves();
        mob1.block();
        mob1.IQ();
        mob1.Strength();
        mob1.Speed();

        Fennec mob2 = new Fennec();
        Console.WriteLine("A friendly fennec appeared");
        mob2.fennec();
        mob2.moves();
        mob2.block();
        mob2.IQ();
        mob2.Strength();
        mob2.Speed();

        Dominus mob3 = new Dominus();
        Console.WriteLine("A mean dominus appeared");
        mob3.dominus();
        mob3.moves();
        mob3.block();
        mob3.IQ();
        mob3.Strength();
        mob3.Speed();
    }
}
