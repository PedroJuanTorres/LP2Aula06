using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BearAdapter
{
    public class BrownBear : IBear
    {
        public bool Hibernating { get; set; }

        public BrownBear(bool hibernating)
        {
            Hibernating = hibernating;
        }

        public void Roar()
        {
            if(Hibernating)
            {
                Console.WriteLine("zzz...");
                
            }
            else
            {
                Console.WriteLine("Rooaarr");
            }
        }
        public void LookAt(object objectToLookAt)
        {
            if(Hibernating)
            {
                Console.WriteLine("zzz...");
            }
            else
            {
                Console.WriteLine($"The bear is looking at {objectToLookAt}");
            }
        }
        public void GoTowards(object objectToWalkTowards)
        {
            if(Hibernating)
            {
                Console.WriteLine("zzz...");
            }
            else
            {
                Console.WriteLine($"The bear gets close to {objectToWalkTowards}");
            }
        }
        public bool TryEat(object objectToEat)
        {
            if(Hibernating)
            {
                return false;
            }
            return true;   
        }
    }
}