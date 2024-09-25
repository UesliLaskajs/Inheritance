namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Husky husky = new Husky();
            husky.Play();
            husky.Run();
            husky.Sound();


            Console.ReadKey();
        }
    }




    public class Animal
    {
        public void Run()
        {
            Console.WriteLine("Run...");
        }

        public virtual void Sound()//Virtual declares a method polymorhmism that can be override in a derived Class 
        {
            Console.WriteLine("Bark...");
        }
    }

    public class Dog : Animal//Dog Inherits From Animal
    {
        public override void Sound()//Overides from the inherited Class Anima virtual method Sound()
        {
            Console.WriteLine("Dog Barks..");
        }
    }

    public class Husky : Dog
    {
        public void Play()
        {
            Console.WriteLine("Husky Plays...");
        }

        public override void Sound()//Overides from the inherited Class Anima virtual method Sound()
        {
            Console.WriteLine("Husky Barks..");
        }
    }

    public class Tiger : Dog
    {
        public void Eats()
        {
            Console.WriteLine("EATS....");
        }

        public override void Sound()
        {
            Console.WriteLine("Tiger Screams");
        }
        
    } 
}