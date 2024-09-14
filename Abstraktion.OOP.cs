namespace Inlämningsuppgift_2_OOP
{
    // Abstrakt basklass
    public abstract class Motorcykel
    {
        // Abstrakt metod utan implementation
        public abstract void Bromsa();
    }

    // Subklass som ärver från Motorcykel
    public class MountainBike : Motorcykel
    {
        // Override av Bromsa-metoden med specifik implementation
        public override void Bromsa()
        {
            Console.WriteLine("MountainBike bromsar");
        }
    }

    // Ny klass: MonarkCykel
    public class MonarkCykel : Motorcykel
    {
        // Override av Bromsa-metoden med specifik implementation
        public override void Bromsa()
        {
            // Simulera krasch
            Console.WriteLine("MonarkCykel bromsarna misslyckades och kraschade!");
        }
    }

    // Huvudprogram
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en instans av MountainBike och anropa Bromsa-metoden
            MountainBike mountainBike = new MountainBike();
            mountainBike.Bromsa(); // Utskrift: "MountainBike bromsar"

            // Skapa en instans av MonarkCykel och anropa Bromsa-metoden
            MonarkCykel monarkCykel = new MonarkCykel();
            monarkCykel.Bromsa(); // Utskrift: "MonarkCykel bromsarna misslyckades och kraschade!"
        }
    }























}







