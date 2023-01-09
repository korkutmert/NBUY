//using Solid04_Liskov_sSubstition.Before;
using Solid04_Liskov_sSubstition.After;

namespace Solid04_Liskov_sSubstition
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Before
            //Guvercin guvercin = new Guvercin();
            //Penguen penguen = new Penguen();
            //Console.WriteLine(guvercin.UcmaMesafesi());
            //Console.WriteLine(penguen.UcmaMesafesi());
            //#endregion
            //Console.ReadLine();

            //Kus[] kuslar = { new Guvercin(), new Penguen(), new Serce() };
            //foreach (var kus in kuslar)
            //{
            //    Console.WriteLine(kus.UcmaMesafesi());
            //}
            #endregion

            #region After
            Kus[] kuslar = { new Guvercin(), new Penguen() };
            foreach (var kus in kuslar)
            {
                Console.WriteLine(kus.);
            }
            #endregion
        }
    }
}