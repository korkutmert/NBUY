
using System.Data.SqlClient;

namespace P01_SqlBaglantiOlusturma;
class Program
{
    static void Main(string[] args)
    {
        GetSqlConnection();
    }
    static void GetSqlConnection()
    {
        //1. Adım --> Connection string olulturmak
        string connectionString = "Server=DESKTOP-OFVK2FD; Database=Northwind; User Id =sa; Password=123";
        using (var connection =new SqlConnection(connectionString) )
        {
            // coonection nesnesi sadece bu scope içinde yaşayıp, scope bitisinde bellekten kaldırılmış olacak!
        try
        {
            connection.Open();
            Console.WriteLine("Bağlantı sağlandı..");

        }
        catch (Exception e)
        {
            
            Console.WriteLine(e.Message);

        }
        finally
        {
            connection.Close();
        }
        }
    }
}
