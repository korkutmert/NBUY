using System.Reflection.Metadata.Ecma335;

namespace Proje05_Methods_Advanced
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Year { get; set; }
            public string Intro()
            {
                return $"Merhaba {this.Name}, Yaş:{this.CalculateAge()} ";
            }
            private int CalculateAge()
            {
                return DateTime.Now.Year - this.Year;
            }


        }
        static void Main(string[] args)
        {
            Person person1 = new Person() { Name = "Mert", Year = 1999 };
            Person person2 = new Person() { Name = "Ali", Year = 1975 };
            Person person3 = new Person() { Name = "Veli", Year = 1985 };
            Person person4 = new Person() { Name = "Mehmet", Year = 2000 };
            Person person5 = new Person() { Name = "Ayşe", Year = 1993 };
           // Console.WriteLine(person3.Intro());
            // Tüm kişilerin Intro bilgilerini ekrana yazdıralım.
            Person[] persons = { person1, person2, person3, person4, person5 };
            foreach (var item in persons)
            {
                Console.WriteLine(item.Intro());
            }
            Console.ReadLine();

            //C#'TA HERŞEY BİR NESNEDİR !!
        }
    }
}