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

        public static void AddAutor(string name, string surname, DateTime dateOfBirth)
        {

            string query = "INSERT INTO AUTOR (imie, nazwisko, data_urodzenia) VALUES (:name, :surname, :dateOfBirth)";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {

                    command.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                    command.Parameters.Add("surname", OracleDbType.Varchar2).Value = surname;
                    command.Parameters.Add("dateOfBirth", OracleDbType.Date).Value = dateOfBirth;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteAutor(string name, string surname, DateTime dateOfBirth)
        {
            string query = "DELETE FROM AUTOR WHERE imie=:name AND nazwisko=:surname AND data_urodzenia=:dateOfBirth";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                    command.Parameters.Add("surname", OracleDbType.Varchar2).Value = surname;
                    command.Parameters.Add("dateOfBirth", OracleDbType.Date).Value = dateOfBirth;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable SearchAutor(string name, string surname, DateTime dateOfBirth)
        {
            string query = "SELECT imie, nazwisko, data_urodzenia FROM AUTOR WHERE imie=:name AND nazwisko=:surname AND data_urodzenia=:dateOfBirth";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                    command.Parameters.Add("surname", OracleDbType.Varchar2).Value = surname;
                    command.Parameters.Add("dateOfBirth", OracleDbType.Date).Value = dateOfBirth;
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

        public static void AddBook(string name, string year, string category, string amount)
        {

            string query = "INSERT INTO KSIAZKA (tytul, rok_wydania, kategoria, dostepnosc) VALUES (:name, :year, :category, :amount)";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {

                    command.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                    command.Parameters.Add("year", OracleDbType.Varchar2).Value = year;
                    command.Parameters.Add("category", OracleDbType.Varchar2).Value = category;
                    command.Parameters.Add("amount", OracleDbType.Varchar2).Value = amount;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteBook(string name, string year, string category, string amount)
        {
            string query = "DELETE FROM KSIAZKA WHERE tytul=:name AND rok_wydania=:year AND kategoria=:category AND dostepnosc=:amount";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                    command.Parameters.Add("year", OracleDbType.Varchar2).Value = year;
                    command.Parameters.Add("category", OracleDbType.Varchar2).Value = category;
                    command.Parameters.Add("amount", OracleDbType.Varchar2).Value = amount;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable SearchBook(string name, string year, string category, string amount)
        {
            string query = "SELECT tytul, rok_wydania, kategoria, dostepnosc FROM KSIAZKA WHERE tytul=:name AND rok_wydania=:year AND kategoria=:category AND dostepnosc=:amount";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                    command.Parameters.Add("year", OracleDbType.Varchar2).Value = year;
                    command.Parameters.Add("category", OracleDbType.Varchar2).Value = category;
                    command.Parameters.Add("amount", OracleDbType.Varchar2).Value = amount;
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

        public static void BorrowBook(
            string phoneNumber,
            string name,
            string surname,
            string bookName,
            DateTime borrowDate,
            DateTime returnDate)
        {
            string query = @"INSERT INTO wypozyczenie (data_wypozyczenia, data_zwrotu, czytelnik_id_czytelnika, ksiazka_id_ksiazki)
             VALUES (:borrowDate, :returnDate, 
                     (SELECT id_czytelnika FROM czytelnik WHERE numer_telefonu = :phoneNumber AND imie = :name AND nazwisko = :surname), 
                     (SELECT id_ksiazki FROM ksiazka WHERE tytul = :bookName))";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("borrowDate", OracleDbType.Date).Value = borrowDate;
                    command.Parameters.Add("returnDate", OracleDbType.Date).Value = returnDate;
                    command.Parameters.Add("phoneNumber", OracleDbType.Varchar2).Value = phoneNumber;
                    command.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                    command.Parameters.Add("surname", OracleDbType.Varchar2).Value = surname;
                    command.Parameters.Add("bookName", OracleDbType.Varchar2).Value = bookName;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable ShowBorrows()
        {
            string query = @"SELECT w.id_wypozyczenia, c.imie, c.nazwisko, c.numer_telefonu, w.data_wypozyczenia, w.data_zwrotu, k.tytul
                     FROM czytelnik c
                     JOIN wypozyczenie w ON c.id_czytelnika = w.czytelnik_id_czytelnika
                     JOIN ksiazka k ON w.ksiazka_id_ksiazki = k.id_ksiazki";

            DataTable dataTable = new DataTable();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        connection.Open();

                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public static void NewReturnDate(int borrowId, DateTime returnDate)
        {
            string query = @"UPDATE wypozyczenie SET data_zwrotu = :returnDate WHERE id_wypozyczenia = :borrowId";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("returnDate", OracleDbType.Date).Value = returnDate;
                    command.Parameters.Add("borrowId", OracleDbType.Int32).Value = borrowId;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void ReturnBook(int borrowId)
        {
            string query = @"DELETE FROM wypozyczenie WHERE id_wypozyczenia = :borrowId";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("borrowId", OracleDbType.Int32).Value = borrowId;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddRelationAutorBook(string bookName, string bookYear, string name, string surname, DateTime dateOfBirth)
        {
            string queryFindBook = @"SELECT id_ksiazki FROM ksiazka WHERE tytul = :bookName AND rok_wydania = :bookYear";
            string queryFindAutor = @"SELECT id_autora FROM autor WHERE imie = :name AND nazwisko = :surname AND data_urodzenia = :dateOfBirth";
            string queryAddRelation = @"INSERT INTO relacja_autor_ksiazka (autor_id_autora, ksiazka_id_ksiazki) VALUES (:idAutor, :idBook)";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                int idBook, idAutor;

                using (OracleCommand command = new OracleCommand(queryFindBook, connection))
                {
                    command.Parameters.Add("bookName", OracleDbType.Varchar2).Value = bookName;
                    command.Parameters.Add("bookYear", OracleDbType.Int32).Value = bookYear;

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idBook = int.Parse(reader["id_ksiazki"].ToString());
                        }
                        else
                        {
                            throw new Exception("Książka nie została znaleziona.");
                        }
                    }
                }
                using (OracleCommand command = new OracleCommand(queryFindAutor, connection))
                {
                    command.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                    command.Parameters.Add("surname", OracleDbType.Varchar2).Value = surname;
                    command.Parameters.Add("dateOfBirth", OracleDbType.Date).Value = dateOfBirth;

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idAutor = int.Parse(reader["id_autora"].ToString());

                        }

                        else
                        {
                            throw new Exception("Autor nie został znaleziony.");
                        }
                    }
                }
                using (OracleCommand command = new OracleCommand(queryAddRelation, connection))
                {
                    command.Parameters.Add("idAutor", OracleDbType.Int32).Value = idAutor;
                    command.Parameters.Add("idBook", OracleDbType.Int32).Value = idBook;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void RemoveRelationAutorBook(string bookName, string bookYear, string name, string surname, DateTime dateOfBirth)
        {
            string queryFindBook = @"SELECT id_ksiazki FROM ksiazka WHERE tytul = :bookName AND rok_wydania = :bookYear";
            string queryFindAutor = @"SELECT id_autora FROM autor WHERE imie = :name AND nazwisko = :surname AND data_urodzenia = :dateOfBirth";
            string queryRemoveRelation = @"DELETE FROM relacja_autor_ksiazka WHERE autor_id_autora = :idAutor AND ksiazka_id_ksiazki = :idBook";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                int idBook, idAutor;

                using (OracleCommand command = new OracleCommand(queryFindBook, connection))
                {
                    command.Parameters.Add("bookName", OracleDbType.Varchar2).Value = bookName;
                    command.Parameters.Add("bookYear", OracleDbType.Int32).Value = bookYear;

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idBook = int.Parse(reader["id_ksiazki"].ToString());
                        }
                        else
                        {
                            throw new Exception("Książka nie została znaleziona.");
                        }
                    }
                }
                using (OracleCommand command = new OracleCommand(queryFindAutor, connection))
                {
                    command.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                    command.Parameters.Add("surname", OracleDbType.Varchar2).Value = surname;
                    command.Parameters.Add("dateOfBirth", OracleDbType.Date).Value = dateOfBirth;

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idAutor = int.Parse(reader["id_autora"].ToString());
                        }
                        else
                        {
                            throw new Exception("Autor nie został znaleziony.");
                        }
                    }
                }
                using (OracleCommand command = new OracleCommand(queryRemoveRelation, connection))
                {
                    command.Parameters.Add("idAutor", OracleDbType.Int32).Value = idAutor;
                    command.Parameters.Add("idBook", OracleDbType.Int32).Value = idBook;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetAuthorAndBookDetails()
        {
            string query = @"SELECT a.imie, a.nazwisko, a.data_urodzenia, k.tytul, k.rok_wydania
                     FROM autor a
                     JOIN relacja_autor_ksiazka r ON a.id_autora = r.autor_id_autora
                     JOIN ksiazka k ON r.ksiazka_id_ksiazki = k.id_ksiazki";

            DataTable dataTable = new DataTable();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

    }
}
