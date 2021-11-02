using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BearAdapter
{
    public class BearAdaptor : IDog
    {
        private IBear bear;
        public void Bark()
        {
            bear.Roar();
        }

        public void Fetch(object objectToFetch)
        {
            bear.LookAt(objectToFetch);
            bear.GoTowards(objectToFetch);
            if(bear.TryEat(objectToFetch))
            {
                Console.WriteLine($"The bear ate {objectToFetch}");
            }
            else
            {
                Console.WriteLine("zzz...");
            }
        }
        public BearAdaptor(IBear bear)
        {
            this.bear = bear;
        }
    }
}