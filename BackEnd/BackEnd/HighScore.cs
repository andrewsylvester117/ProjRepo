﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_End
{
    public class HighScore
    {
        private int gameHighScore;
        public int GameHighScore
        {
            get { return gameHighScore; }
            set
            {
                gameHighScore = value;
            }
        }
    }
}
