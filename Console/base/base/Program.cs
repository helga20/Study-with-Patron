using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

namespace database
{

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            SQLiteConnection connection;
            connection = CreateConnection();
            CreateTables(connection);
            for (int i = 0; i < 50; ++i)
            {
                InsertData(connection);
            }
            ReadData(connection);
        }
        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection connection;
            connection = new SQLiteConnection("Data Source=rating.db;Version=3;New=True;Compress=True;");
            try { connection.Open(); }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return connection;
        }
        static void CreateTables(SQLiteConnection sqcon)
        {
            SQLiteCommand sqlitecom;

            string CreateUserScores = "CREATE TABLE IF NOT EXISTS UserScores (Id INTEGER PRIMARY KEY NOT NULL," +
                "name TEXT NOT NULL, result INTEGER NOT NULL);";

            string CreateBombs = "CREATE TABLE IF NOT EXISTS Bombs (Id INTEGER PRIMARY KEY NOT NULL, " +
                "score INTEGER NOT NULL, FOREIGN KEY (Id) REFERENCES UserScores (Id) ON DELETE CASCADE);";

            sqlitecom = sqcon.CreateCommand();

            sqlitecom.CommandText = CreateUserScores;
            sqlitecom.ExecuteNonQuery();

            sqlitecom.CommandText = CreateBombs;
            sqlitecom.ExecuteNonQuery();
        }
        static string CreateUser(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        static void InsertData(SQLiteConnection sqcon)
        {
            //SQLiteCommand sqlitecom;
            //sqlitecom = sqcon.CreateCommand();

            //sqlitecom.CommandText = " DROP Table 'BestPlayers'";
            //sqlitecom.CommandText = " DROP Table 'UserScores'";
            //sqlitecom.CommandText = " DROP Table 'Bombs'";

            //sqlitecom.ExecuteNonQuery();

            //будь-шо
            //наприклад ось це


            SQLiteCommand sqlitecom;
            sqlitecom = sqcon.CreateCommand();
            Random rnd = new Random();
            int user_res = rnd.Next(1, 100);
            int bomb_score = rnd.Next(1, 100);
            int total = user_res + bomb_score;
            int id = rnd.Next(1, 5000);
            sqlitecom.CommandText = "INSERT INTO UserScores(Id, name, result) VALUES ('" + id + "' , '" + CreateUser(7) + "', '" + user_res + "' )";
            sqlitecom.ExecuteNonQuery();

            sqlitecom.CommandText = "INSERT INTO Bombs(Id, score) VALUES ('" + id + "', '" + bomb_score + "' )";
            sqlitecom.ExecuteNonQuery();

            sqlitecom.CommandText = "INSERT INTO BestPlayers(Id, total) VALUES ('" + id + "', '" + total + "' )";
            sqlitecom.ExecuteNonQuery();
        }
        static void ReadData(SQLiteConnection sqcon)
        {
            SQLiteDataReader sqliteread;
            SQLiteCommand sqlitecom;
            sqlitecom = sqcon.CreateCommand();
            sqlitecom.CommandText = "SELECT * FROM UserScores";
            sqliteread = sqlitecom.ExecuteReader();
            Console.WriteLine($"{sqliteread.GetName(0),-3} {sqliteread.GetName(1),-8} {sqliteread.GetName(2),8}");
            while (sqliteread.Read())
            {

                Console.WriteLine($"{sqliteread.GetInt32(0)} {sqliteread.GetString(1)} {sqliteread.GetInt32(2)}");
            }
            SQLiteDataReader sqliteread2;
            SQLiteCommand sqlitecom2;
            sqlitecom = sqcon.CreateCommand();
            sqlitecom.CommandText = "SELECT * FROM Bombs";
            sqliteread2 = sqlitecom.ExecuteReader();
            Console.WriteLine($"{sqliteread2.GetName(0),-3} {sqliteread2.GetName(1),8}");
            while (sqliteread2.Read())
            {

                Console.WriteLine($"{sqliteread2.GetInt32(0)} {sqliteread2.GetInt32(1)}");
            }

            SQLiteDataReader sqliteread3;
            SQLiteCommand sqlitecom3;
            sqlitecom = sqcon.CreateCommand();
            sqlitecom.CommandText = "SELECT * FROM BestPlayers";
            sqliteread3 = sqlitecom.ExecuteReader();
            Console.WriteLine($"{sqliteread3.GetName(0),-3} {sqliteread3.GetName(1),-8}");
            while (sqliteread3.Read())
            {

                Console.WriteLine($"{sqliteread3.GetInt32(0)} {sqliteread3.GetInt32(1)}");
            }
            sqcon.Close();
        }
    }
}