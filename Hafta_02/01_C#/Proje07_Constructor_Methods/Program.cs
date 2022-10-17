namespace Proje07_Constructor_Methods
{
    class Person
    {
        public Person()//Constructor Metot. Bu metotların tipi olmaz.(Void,int vb)
        {
            //Her classın default olarak boş bir constructor metodu vardır ama implicit'tır. Yani örtülüdür.Şuanda biz kendimiz constructor metot yazdık.
            //Constructor metot, ilgili class'tan new keywordü ile yeni bir nesne yaratıldığı esnada çalışacak kodları barındırır.
            //Yani, bu classtan bir nesne üretildiği anda ilk olarak buradaki kodlar çalışır.
            Console.WriteLine("Merhaba, ben Person. Şuan yaratıldım !");
        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;    
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Student:Person 
    {
        public Student(string firstName, string lastName, int studentNumber) : base(firstName,lastName)            // 'Ctor' komutu direkt const. oluşturur.
        {
           
            StudentNumber = studentNumber;
        }
        public int StudentNumber { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person1 = new Person("Mert", "Korkut");
            Console.WriteLine($"{person1.FirstName} {person1.LastName}");
           Student student1 = new Student("Ahmet", "Can",519);
            Console.WriteLine($"First Name : {student1.FirstName}, Last Name : {student1.LastName}, Student Number : {student1.StudentNumber} ");
            Console.ReadLine();
        }
         
    }

}