
namespace Inlämningsuppgift_2_OOP
{
    public class Drinks
    {

        public string Name;
        public string Description;

        // Virtuell metod som kan överskridas i underklasser
        public virtual void Start()
        {
            Console.WriteLine("The drink is fantastic");
        }
    }

    public class FantaExotic : Drinks
    {
        // Override för att ändra basbeteendet
        public override void Start()
        {
            Console.WriteLine("The drink is heavenly");
        }
    }

    public class CocaCola : Drinks
    {
        // Override för att ändra basbeteendet
        public override void Start()
        {
            Console.WriteLine("More drinking is needed");
        }
    }

    class Program
    {
        // Huvudmetoden där programmet startar
        static void Main(string[] args)
        {
            // Skapa en instans av basklassen Drinks och anropa metoden Start
            Drinks myDrinks = new Drinks();
            myDrinks.Start();

            // Skapa en instans av FantaExotic och anropa den överskrivna Start-metoden
            FantaExotic exoticDrink = new FantaExotic();
            exoticDrink.Start();

            // Skapa en instans av CocaCola och anropa den överskrivna Start-metoden
            CocaCola colaDrink = new CocaCola();
            colaDrink.Start();
        }
    }
}
