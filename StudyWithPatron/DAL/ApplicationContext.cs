using Microsoft.EntityFrameworkCore;
using StudyWithPatron.BLL;
using System;
using System.IO;

namespace StudyWithPatron.DAL
{
    public class ApplicationContext : DbContext
    {
        //CREATE TABLE IF NOT EXISTS UserScore (Id INTEGER PRIMARY KEY NOT NULL, name TEXT NOT NULL, result INTEGER NOT NULL);
        //CREATE TABLE IF NOT EXISTS Bombs (Id INTEGER PRIMARY KEY NOT NULL, score INTEGER NOT NULL, FOREIGN KEY (Id) REFERENCES UserScores (Id) ON DELETE CASCADE);

        public DbSet<UserScores> UserScore { get; set; }

        public DbSet<Bombs> Bomb { get; set; }

        public string path = Path.Combine(Environment.CurrentDirectory, @"DAL", "UserScoresDB.db");

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={path}");

    }
}

