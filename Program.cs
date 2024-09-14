namespace Inlämningsuppgift_2_OOP

{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en ny Porsche
            Porsche myPorsche = new Porsche();

            // Anropa metoden scream()
            myPorsche.scream();

            // Anropa metoden flying()
            myPorsche.flying();
        }
    }
    // DETTA ÄR HUVUDKLASSEN
    public class Car
    {
        public string model;
        public int year;

        //METOD AV KLASSEN
        public virtual void scream()
        {
            Console.WriteLine("This car makes a sound");
        }
    }

    public class Porsche : Car
    {
        public int engineSize;

        public override void scream()
        {
            Console.WriteLine("This Porsche roars loudly!");
        }

        public new void flying()
        {
            Console.WriteLine("This Porsche is flying at high speeds!");
        }
    }
}