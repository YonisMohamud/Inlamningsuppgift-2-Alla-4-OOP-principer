using System;


namespace Inlämningsuppgift_2_OOP
{

    public class Student
    {
        // Privat attribut som bara kan nås via metoder
        private string name;

        //Konstruktor för att sätta namn när ett objekt skapas
        public Student(string name)
        {
            this.name = name;
        }

        // Public metod för att hämta namnet 

        public string Getname()
        {
            return name;
        }


        // Public metod för att ändra namnet

        public void Setname(string newName)
        {
            name = newName;
        }
             
         }

        class program
         { 
         static void Main(string[] args)
        {
            // Skapa ett nytt Student-objekt med namnet "Yonis"

            Student student1 = new Student("Yonis");


            // Skriv ut nuvarande namn

            Console.WriteLine(student1.Getname());

            // Ändra namnet till "Noah"

            student1.Setname("Noah");

            // Skriv ut det uppdaterade namnet 

            Console.WriteLine("Uppdaterade namn: "+ student1.GetName ());




        }
    
    
    
    
    
         }

}






