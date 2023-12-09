﻿using Monopoly.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Core
{
    internal class GameRules
    {
        public int NumberOfPlayers { get; set; }
        public int NumberOfDice { get; set; }
        public int DieSides { get; set; }
        public Language GameLanguage { get; set; }
        public int Salary {  get; set; }
        public bool DoubleOnGo { get; set; }
        public Parking FreeParking { get; set; }
        public GameRules(int numberOfPlayers, int numberOfDice, int dieSides)
        {
            NumberOfPlayers = numberOfPlayers;
            NumberOfDice = numberOfDice;
            DieSides = dieSides;
            GameLanguage = Language.UK;
            Salary = 200;
        }

        public enum Language
        {
            UK,
            US
        }

        public enum Parking
        {
            Classic,
            SetFee,
            Fines
        }
    }
}
