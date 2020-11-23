﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _23_11_2020
{
    public class Player
    {
        public int ID { get; set; }
        public string PlayerName { get; set; }
        public int Score { get;private set; }
        public Player(int id,string playername,int score)
        {
            ID = id;
            PlayerName = playername;
            Score = score;
        }
        public void IncreaseScore(int ValueToAdd)
        {
            if (Score < 100)
            {
                Score += ValueToAdd;
            }
        }
    }
}
