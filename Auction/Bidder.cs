using System;
using System.Collections.Generic;
using System.Text;

namespace Auction
{
    class Bidder : Observer
    {
        private string name;
        public double bidPrice;

        public Bidder(string name)
        {
            this.name = name;
        }

        public void update()
        {
            Console.WriteLine(name + " propose: " + bidPrice+"\n");

            if (bidPrice > 450)
            {
                Console.WriteLine("Sold!! " + name);
            }
        }

        public void giveNewPrice(double price)
        {
            bidPrice = price;
        }
    }
}
