﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotballBetting.Data.Models
{
    public class Bet
    {
        public int BetId { get; set; }
        public int Amount { get; set; }
        public string? Prediction { get; set; }
        public DateTime DateTime { get; set; }
        public int UserId { get; set; }
        public int GameId { get; set; }

        //many to one
        public User? User { get; set; }
        public Game? Game { get; set; }
    }
}
