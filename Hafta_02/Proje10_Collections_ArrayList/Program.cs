using System.Collections;

namespace Proje10_Collections_ArrayList
{
    internal class Program
    {   
        static void Yazdir(ArrayList arrayList)
        {
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }   
        }
        static void Main(string[] args)
        {
            ArrayList sayilar = new ArrayList() { 54, 12, 66, 34, 19 };
            Console.WriteLine("Default sıra");
            Yazdir(sayilar);
            sayilar.Sort();
           
            Console.WriteLine("********");

            Console.WriteLine("Küçükten büyüğe");
            Yazdir(sayilar);

            Console.WriteLine("********");

            Console.WriteLine("Büyükten Küçüğe");
            sayilar.Reverse();
            Yazdir(sayilar);
         
           // ArrayList myList = new ArrayList();
           // myList.Add(120);
           // myList.Add("120");
           // myList.Add("Mert");
           // myList.Add(11.5);
           // myList.Add(DateTime.Now);
           // myList.Add(true);
           // myList.Insert(0,"Yeni Eleman");

           // ArrayList addedList = new ArrayList() { "mert", "Korkut", "Muslu" };
           // myList.InsertRange(4, addedList);// Dİrekt başka liste ekler.
           // myList.AddRange(addedList);//Listenin sonuna ekler.
           //// myList.Remove("120");//Parantezdeki elemanı siler.
           //// myList.RemoveAt(0);//0.indexi sil.
           //// myList.RemoveRange(0, 5);//0'dan itibaren 5 tane sil.
           // foreach (var item in myList)

           // {
           //     Console.WriteLine(item);

           // }
           // if (myList.Contains("Mert") == true)
           // {
           //     Console.WriteLine("Evet Listede MEvcut.");
           // }
           // else
           // {
           //     Console.WriteLine("haber ver gelsin");
           // }
           // Console.WriteLine();
           // Console.WriteLine(myList[3]); //3.indexteki elemanı yaz.

           
            Console.ReadLine();
        }
    }
}