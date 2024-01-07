using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace LibraryApp
{
    public class DatabaseAccess
    {
        private readonly string connectionString;

        public DatabaseAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable ExecuteQuery(string query)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                    return dataTable;
                }
            }
        }

        public void AddUser(string name, string surname, string phoneNumber)
        {
            string query = "INSERT INTO CZYTELNIK (imie, nazwisko, numer_telefonu) VALUES (@name, @surname, @phoneNumber);";

            using(MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using(MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@surname", surname);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteUser(string name, string surname, string phoneNumber)
        {
            string query = "DELETE FROM CZYTELNIK WHERE imie=@name AND nazwisko=@surname AND numer_telefonu=@phoneNumber;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@surname", surname);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable SearchUser(string name, string surname, string phoneNumber)
        {
            string query = "SELECT imie, nazwisko, numer_telefonu FROM CZYTELNIK WHERE imie=@name AND nazwisko=@surname AND numer_telefonu=@phoneNumber;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@surname", surname);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    connection.Open();

                    using(MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public void AddWorker(string name, string surname, string position)
        {
            string query = "INSERT INTO PRACOWNIK (imie, nazwisko, stanowisko) VALUES (@name, @surname, @position);";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@surname", surname);
                    command.Parameters.AddWithValue("@position", position);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteWorker(string name, string surname, string position)
        {
            string query = "DELETE FROM PRACOWNIK WHERE imie=@name AND nazwisko=@surname AND stanowisko=@position;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@surname", surname);
                    command.Parameters.AddWithValue("@position", position);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable SearchWorker(string name, string surname, string position)
        {
            string query = "SELECT imie, nazwisko, stanowisko FROM PRACOWNIK WHERE imie=@name AND nazwisko=@surname AND stanowisko=@position;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@surname", surname);
                    command.Parameters.AddWithValue("@position", position);
                    connection.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
    }
}
