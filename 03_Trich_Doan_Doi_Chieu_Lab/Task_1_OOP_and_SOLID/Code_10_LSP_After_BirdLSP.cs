public abstract class BirdLSP
{
    public abstract void Eat();
    public abstract void Sleep();
}
 
public class PenguinLSP : BirdLSP
{
    public override void Eat() { Console.WriteLine("Penguin is eating fish."); }
    public override void Sleep() { Console.WriteLine("Penguin is sleeping."); }
}
