﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_IncreaseCounterService
{
    public class IncreaseCounterService
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Third { get; set; }

        public void IncreaseCounters(int number)
        {
            if (number > 3 && number <= 5)
            {
                First++;
            }
            else if (number > 5 && number <= 7)
            {
                Second++;
            }
            else if (number > 7)
            {
                Third++;
            }
        }
    }
}
