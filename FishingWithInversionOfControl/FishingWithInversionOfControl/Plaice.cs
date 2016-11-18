using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingWithInversionOfControl
{
    public class Plaice : ICatch
    {
        public string WhatFishHasBeenCaught()
        {
            return "Caught a plaice.";
        }
    }
}
