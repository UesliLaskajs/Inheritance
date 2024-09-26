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

            Person person = new Person("Uesli", "Laska", 20);
            person.DisplayInfo();

            Employee emp = new Employee("Bruno", "Laska", 13, "Manager", 5000);
            emp.DisplayEmployee();

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
            base.Sound();//Calls the First Animal Build Method from Base Class than Dog Barks from derived class
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