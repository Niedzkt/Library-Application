using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace LibraryApp
{
    public class DatabaseAccess
    {
        private static readonly string connectionString = @"DATA SOURCE=192.168.1.21:1521/XE;" + "USER ID=libdb; PASSWORD=passwordlib";

        public static DataTable ExecuteQuery(string query)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    connection.Open();
                    DataTable dataTable = new DataTable();
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                    return dataTable;
                }
            }
        }

        public static void AddUser(string name, string surname, string phoneNumber)
        {
            string query = "INSERT INTO CZYTELNIK (imie, nazwisko, numer_telefonu) VALUES (:name, :surname, :phoneNumber)";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                    command.Parameters.Add("surname", OracleDbType.Varchar2).Value = surname;
                    command.Parameters.Add("phoneNumber", OracleDbType.Varchar2).Value = phoneNumber;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteUser(string name, string surname, string phoneNumber)
        {
            string query = "DELETE FROM CZYTELNIK WHERE imie=:name AND nazwisko=:surname AND numer_telefonu=:phoneNumber";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                    command.Parameters.Add("surname", OracleDbType.Varchar2).Value = surname;
                    command.Parameters.Add("phoneNumber", OracleDbType.Varchar2).Value = phoneNumber;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable SearchUser(string name, string surname, string phoneNumber)
        {
            string query = "SELECT imie, nazwisko, numer_telefonu FROM CZYTELNIK WHERE imie=:name AND nazwisko=:surname AND numer_telefonu=:phoneNumber";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                    command.Parameters.Add("surname", OracleDbType.Varchar2).Value = surname;
                    command.Parameters.Add("phoneNumber", OracleDbType.Varchar2).Value = phoneNumber;
                    connection.Open();

                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public static void AddWorker(string name, string surname, string position)
        {
            
            string query = "INSERT INTO PRACOWNIK (imie, nazwisko, stanowisko) VALUES (:name, :surname, :position)";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
               
                    command.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                    command.Parameters.Add("surname", OracleDbType.Varchar2).Value = surname;
                    command.Parameters.Add("position", OracleDbType.Varchar2).Value = position;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteWorker(string name, string surname, string position)
        {
            string query = "DELETE FROM PRACOWNIK WHERE imie=:name AND nazwisko=:surname AND stanowisko=:position";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                    command.Parameters.Add("surname", OracleDbType.Varchar2).Value = surname;
                    command.Parameters.Add("position", OracleDbType.Varchar2).Value = position;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable SearchWorker(string name, string surname, string position)
        {
            string query = "SELECT imie, nazwisko, stanowisko FROM PRACOWNIK WHERE imie=:name AND nazwisko=:surname AND stanowisko=:position";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                    command.Parameters.Add("surname", OracleDbType.Varchar2).Value = surname;
                    command.Parameters.Add("position", OracleDbType.Varchar2).Value = position;
                    connection.Open();

                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public static void AddAddress(string street, string address, string city, string postcode)
        {

            string query = "INSERT INTO ADRES (ulica, mieszkanie, miejscowosc, kod_pocztowy) VALUES (:street, :address, :city, :postcode)";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {

                    command.Parameters.Add("street", OracleDbType.Varchar2).Value = street;
                    command.Parameters.Add("address", OracleDbType.Varchar2).Value = address;
                    command.Parameters.Add("city", OracleDbType.Varchar2).Value = city;
                    command.Parameters.Add("postcode", OracleDbType.Varchar2).Value = postcode;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteAddress(string street, string address, string city, string postcode)
        {
            string query = "DELETE FROM ADRES WHERE ulica=:street AND mieszkanie=:address AND miejscowosc=:city AND kod_pocztowy=:postcode";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("street", OracleDbType.Varchar2).Value = street;
                    command.Parameters.Add("address", OracleDbType.Varchar2).Value = address;
                    command.Parameters.Add("city", OracleDbType.Varchar2).Value = city;
                    command.Parameters.Add("postcode", OracleDbType.Varchar2).Value = postcode;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable SearchAddress(string street, string address, string city, string postcode)
        {
            string query = "SELECT ulica, mieszkanie, miejscowosc, kod_pocztowy FROM ADRES WHERE ulica=:street AND mieszkanie=:address AND miejscowosc=:city AND kod_pocztowy=:postcode";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("street", OracleDbType.Varchar2).Value = street;
                    command.Parameters.Add("address", OracleDbType.Varchar2).Value = address;
                    command.Parameters.Add("city", OracleDbType.Varchar2).Value = city;
                    command.Parameters.Add("postcode", OracleDbType.Varchar2).Value = postcode;
                    connection.Open();

                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public static void AddAutor(string name, string surname, string dateOfBirth)
        {

            string query = "INSERT INTO AUTOR (imie, nazwisko, data_urodzenia) VALUES (:name, :surname, :dateOfBirth)";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {

                    command.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                    command.Parameters.Add("surname", OracleDbType.Varchar2).Value = surname;
                    command.Parameters.Add("dateOfBirth", OracleDbType.Varchar2).Value = dateOfBirth;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteAutor(string name, string surname, string dateOfBirth)
        {
            string query = "DELETE FROM AUTOR WHERE imie=:name AND nazwisko=:surname AND data_urodzenia=:dateOfBirth";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                    command.Parameters.Add("surname", OracleDbType.Varchar2).Value = surname;
                    command.Parameters.Add("dateOfBirth", OracleDbType.Varchar2).Value = dateOfBirth;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable SearchAutor(string name, string surname, string dateOfBirth)
        {
            string query = "SELECT imie, nazwisko, data_urodzenia FROM AUTOR WHERE imie=:name AND nazwisko=:surname AND data_urodzenia=:dateOfBirth";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                    command.Parameters.Add("surname", OracleDbType.Varchar2).Value = surname;
                    command.Parameters.Add("dateOfBirth", OracleDbType.Varchar2).Value = dateOfBirth;
                    connection.Open();

                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
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
