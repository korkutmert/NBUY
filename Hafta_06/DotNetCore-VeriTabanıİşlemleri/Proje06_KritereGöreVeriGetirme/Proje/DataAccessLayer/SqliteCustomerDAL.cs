using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Proje.DataAccessLayer.Entities;

namespace Proje.DataAccessLayer
{
    public class SqliteCustomerDAL : ICustomerDAL
    {
        private SqliteConnection GetSqliteConnection()
        {
            string connectionString = "Data Source = NorthWind.db";
            SqliteConnection sqliteConnection = new SqliteConnection(connectionString);
            return sqliteConnection;
        }
        public void Create(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GettAll()
        {
            List<Customer> customers = new List<Customer>();
            using (SqliteConnection connection = GetSqliteConnection())
            {
                try
                {
                    connection.Open();
                    string queryString = "SELECT CustomerId, CompanyName, ContactName, Country FROM Customers";
                    SqliteCommand sqliteCommand = new SqliteCommand(queryString, connection);
                    SqliteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
                    while (sqliteDataReader.Read())
                    {
                        customers.Add(new Customer(){
                            Id = sqliteDataReader["CustomerId"].ToString(),
                            CompanyName = sqliteDataReader["CompanyName"].ToString(),
                            ContactName = sqliteDataReader["ContactName"].ToString(),
                            Country = sqliteDataReader["Country"].ToString()
                        });
                    }
                    sqliteDataReader.Close();
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir hata oluştu!");
                }
                finally
                {
                    connection.Close();
                }
            }
            return customers;
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}