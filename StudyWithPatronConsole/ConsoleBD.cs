using Microsoft.Data.Sqlite;
using StudyWithPatronConsole.Properties;
using System.Text;
//using Study.Properties;

namespace StudyWithPatron
{
    internal static class ConsoleBD
    {
        [STAThread]
        static void Main()
        {
            SqliteConnection connection;
            connection = CreateConnection();
            CreateTables(connection);
            for (int i = 0; i < 5; ++i)
            {
                InsertData(connection);
            }
            CreateView(connection);
            ReadData(connection);

        }

        static SqliteConnection CreateConnection()
        {
            SqliteConnection connection;
            connection = new SqliteConnection(DataBaseProperties.DBConnection);
            try { connection.Open(); }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return connection;
        }

        static void CreateTables(SqliteConnection sqcon)
        {
            SqliteCommand sqlitecom;

            sqlitecom = sqcon.CreateCommand();

            sqlitecom.CommandText = DataBaseProperties.CreateUserScores;
            sqlitecom.ExecuteNonQuery();

            sqlitecom.CommandText = DataBaseProperties.CreateBombs;
            sqlitecom.ExecuteNonQuery();

            sqlitecom.CommandText = DataBaseProperties.CreateView;
            sqlitecom.ExecuteNonQuery();
        }

        static void CreateView(SqliteConnection sqcon)
        {
            SqliteCommand sqlitecom;
            sqlitecom = sqcon.CreateCommand();
            sqlitecom.CommandText = DataBaseProperties.CreateView;
            sqlitecom.ExecuteNonQuery();
        }

        static string CreateUser(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new ();
            Random rnd = new ();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        static void InsertData(SqliteConnection sqcon)
        {
            /*
               SQLiteCommand sqlitecom;
               sqlitecom = sqcon.CreateCommand();
               sqlitecom.CommandText = " DROP Table 'UserScores'";
               sqlitecom.CommandText = " DROP Table 'Bombs'";
              */

            SqliteCommand sqlitecom;
            sqlitecom = sqcon.CreateCommand();
            Random rnd = new ();
            int user_res = rnd.Next(1, 100);
            int bomb_score = rnd.Next(1, 100);
            int id = rnd.Next(1, 10000);
            sqlitecom.CommandText = "INSERT INTO UserScores(Id, name, result) VALUES ('" + id + "' , '" + CreateUser(7) + "', '" + user_res + "' )";
            sqlitecom.ExecuteNonQuery();

            sqlitecom.CommandText = "INSERT INTO Bombs(Id, score) VALUES ('" + id + "', '" + bomb_score + "' )";
            sqlitecom.ExecuteNonQuery();

        }

        static void ReadData(SqliteConnection sqcon)
        {
            SqliteDataReader sqliteread;
            SqliteCommand sqlitecom;
            sqlitecom = sqcon.CreateCommand();
            sqlitecom.CommandText = "SELECT * FROM UserScores";
            sqliteread = sqlitecom.ExecuteReader();
            Console.WriteLine($"{sqliteread.GetName(0),-3} {sqliteread.GetName(1),-8} {sqliteread.GetName(2),8}");
            while (sqliteread.Read())
            {
                Console.WriteLine($"{sqliteread.GetInt32(0)} {sqliteread.GetString(1)} {sqliteread.GetInt32(2)}");
            }

            SqliteDataReader sqliteread2;
            SqliteCommand sqlitecom2;
            sqlitecom2 = sqcon.CreateCommand();
            sqlitecom2.CommandText = "SELECT * FROM Bombs";
            sqliteread2 = sqlitecom2.ExecuteReader();
            Console.WriteLine($"{sqliteread2.GetName(0),-3} {sqliteread2.GetName(1),8}");
            while (sqliteread2.Read())
            {
                Console.WriteLine($"{sqliteread2.GetInt32(0)} {sqliteread2.GetInt32(1)}");
            }

            SqliteDataReader sqliteread3;
            SqliteCommand sqlitecom3;
            sqlitecom3 = sqcon.CreateCommand();
            sqlitecom3.CommandText = "SELECT * FROM Total";
            sqliteread3 = sqlitecom3.ExecuteReader();
            Console.WriteLine($"{sqliteread3.GetName(0),-3} {sqliteread3.GetName(1),-8}");
            while (sqliteread3.Read())
            {
                Console.WriteLine($"{sqliteread3.GetString(0)} {sqliteread3.GetInt32(1)}");
            }
            sqcon.Close();
        }

    }
}