using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace StudyWithPatron.DAL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<UserScores> UserScore { get; set; }


        // string path = Path.Combine(Environment.CurrentDirectory, @"DAL\", "UserScoresBD.db");

        public string path = @"D:\Навчання\StudyWithPatron\DAL\UserScoresBD.db";

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={path}");



    }
}

