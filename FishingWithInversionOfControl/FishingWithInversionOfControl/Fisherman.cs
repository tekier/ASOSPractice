using System;

namespace FishingWithInversionOfControl
{
    public class Fisherman
    {
        private readonly ICatch _fishCaught;
        public Fisherman(ICatch fishCaught)
        {
            _fishCaught = fishCaught;
        }

        public void WhatFishHasBeenCaught()
        {
            Console.WriteLine(_fishCaught.WhatFishHasBeenCaught());
        }
    }
}
