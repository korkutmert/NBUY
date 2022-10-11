using System.Reflection.Metadata.Ecma335;

namespace Proje06_Inheritance_Kalıtım_Miras
{
    class Person // Bir class istenildiği kadar başka classa miras verebilir.
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual void Intro() // Virtual : Bu metodun miras alınan classlarda override edilemsine izin verir.
        {
            Console.WriteLine($"First Name : {this.FirstName} , Last Name : {this.LastName}");
        }
    }
    class writer:Person
    {
        public string BookName { get; set; }

    }
    class Teacher:Person
    {
        public string Branch { get; set; }
    }
    class Student:Person // Person classından miras aldı. Yani öğrenci classına person klasındaki ad soyad bilgileri eklendi. Bir Class sadece tek bir classtan miras alabilir.
    {
      
        public int StudentNumber { get; set; }
        public override void Intro()//Bu metodun miras alınan sınıftaki versiyonu ezip yok sayıp yerine bu metodu kabul eder.
        {
            Console.WriteLine($"First Name : {this.FirstName} , Last Name : {this.LastName} , Student Number : {this.StudentNumber}");
        }
    }
    class a
    {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
    }
    class b : a 
    {
        public int MyProperty3 { get; set; }
        public int MyProperty4 { get; set; }
    }
    class c : b 
    {
        public int MyProperty5 { get; set; }
        public int MyProperty6 { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Student student = new Student();
            Teacher teacher = new Teacher();
            student.FirstName = "Kemal";
            student.LastName = " Kapucu";
            student.StudentNumber = 125;
            student.Intro();                      
            teacher.FirstName = "Mert";
            teacher.LastName = "Muslu";
            teacher.Branch = "Mekatronik";
            teacher.Intro();
            Console.ReadLine();

            Person person1 = new Student(); // Her öğrenci bir insandır öreeği gibi düşün.
            //Student student1 = new Person();Bu hatalı kullanımdır.
           


        
            
            

        }
    }
}