﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyWithPatron.BLL
{
    public class Bombs
    {
        //CREATE TABLE IF NOT EXISTS Bomb (Id INTEGER PRIMARY KEY NOT NULL, score INTEGER NOT NULL, FOREIGN KEY (Id) REFERENCES UserScores (Id) ON DELETE CASCADE);
        public int Id { get; set; }

        public int result { get; set; }

        public int id_scores { get; set; }
        public Bombs(int result, int id_scores)
        {
            this.result = result;
            this.id_scores = id_scores;
        }
    }
}
