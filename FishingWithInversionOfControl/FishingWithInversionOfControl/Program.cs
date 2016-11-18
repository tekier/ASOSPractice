using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingWithInversionOfControl
{
    class Program
    {
        static void Main(string[] args)
        {
            ResolveFish resolver = new ResolveFish();
            resolver.Register<Fisherman, Fisherman>();
            Console.WriteLine("high|low tide? ");
            var whatIsTheStateOfTheTide = "low";
            if (whatIsTheStateOfTheTide.Equals("high"))
            {
                resolver.Register<ICatch, Mackerel>();
                var fisherman = resolver.ResolveFishCaught<Fisherman>();
                fisherman.WhatFishHasBeenCaught();
            }
            else if (whatIsTheStateOfTheTide.Equals("low"))
            {
                resolver.Register<ICatch, Plaice>();
                var fisherman = resolver.ResolveFishCaught<Fisherman>();
                fisherman.WhatFishHasBeenCaught();
            }
            else
            {
                Console.WriteLine("not valid state of tide.");
            }
            Console.ReadLine();
        }
    }
}
