namespace Proje08_Abstract
{
   abstract class Person // eğer bir class abstract ise o classtan yeni nesne yaratılamaz. // Person person1 =new Person("hali","mutlu"); gibi komut olaamaz. Nesene üretilemezz !!.
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Console.WriteLine("Person is created.");
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Greeting()
        {
            Console.WriteLine("Im a person.");
        }
        public abstract void Intro(); // Soyut metot. Abstarct soyutlar. Eğer bir claasın içinde abstract bir metot var ise o class'da abstract olmalıdır.(yukarda class personun başında abstract yazdık)!!
    }


    class Student:Person
    {
        public Student(string firstName, string lastName, int studentNumber):base(firstName, lastName)
        {
            StudentNumber = studentNumber;
            Console.WriteLine("Stundent is created.");
        }
        public int StudentNumber { get; set; }

        public override void Intro()
        {
            Console.WriteLine($"Frst Name: {FirstName} Last Name: {LastName} Student Number: {StudentNumber}");
        }
    }

    class Teacher:Person
    {
        public Teacher(string firstName, string lastName, string branch) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Branch = branch;
            Console.WriteLine("Teacher is created.");
        }
        public string Branch { get; set; }

        public override void Intro()
        {
            Console.WriteLine($"Frst Name: {FirstName} Last Name: {LastName} Branch: {Branch}");
        }

        public void Teach()
        {
            Console.WriteLine("Hi ım Teaching!");
        }
    }
    class Writer:Person
    {
        public Writer(string firstName, string lastName ,string bookName): base (firstName,lastName)
        {
            LastName=lastName;
            FirstName=firstName;
            BookName = bookName;
            Console.WriteLine("Writer is created.");
        }

        public string BookName { get; set; }

        public override void Intro()
        {
            Console.WriteLine($"Frst Name: {FirstName} Last Name: {LastName} Book Name: {BookName}");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("mert korkut", "muslu", 500);
            
            student1.Intro();//İstemedğimiz halde Person'daki Intro  çalışıyor.
           
            Console.WriteLine("*************************");
            
            Teacher teacher1 = new Teacher("Ali", "Veli", "Matematik");
            
            teacher1.Intro();///İstemedğimiz halde Person'daki Intro  çalışıyor.
            
            Console.WriteLine("*************************");
           
            Writer writer1 = new Writer("mehmet", "samet", "beyaz diş");
           
            writer1.Intro();
            
            
            Console.ReadLine();

        }
    }
}