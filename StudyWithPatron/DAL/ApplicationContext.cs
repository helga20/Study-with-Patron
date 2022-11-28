using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.IO;
using StudyWithPatron.BLL;

namespace StudyWithPatron.DAL
{
    public class ApplicationContext : DbContext
    {
        //CREATE TABLE IF NOT EXISTS UserScore (Id INTEGER PRIMARY KEY NOT NULL, name TEXT NOT NULL, result INTEGER NOT NULL);
        //CREATE TABLE IF NOT EXISTS Bombs (Id INTEGER PRIMARY KEY NOT NULL, score INTEGER NOT NULL, FOREIGN KEY (Id) REFERENCES UserScores (Id) ON DELETE CASCADE);

        public DbSet<UserScores> UserScore { get; set; }
        
        public DbSet<Bombs> Bomb { get; set; }

        // string path = Path.Combine(Environment.CurrentDirectory, @"DAL", "RatingDB.db");

        //public string path = @"C:\Users\Lenovo\Source\Repos\helga20\Study-with-Patron\StudyWithPatron\DAL\UserScoresDB.db";
        //string path = Path.Combine(Environment.CurrentDirectory, @"DAL", "UserScoresDB.db");
        string path = Path.Combine(Environment.CurrentDirectory, @"DAL", "RatingDB.db");

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={path}");

    }
}

