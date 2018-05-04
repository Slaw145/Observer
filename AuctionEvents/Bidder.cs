using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionEvents
{
    public class Bidder
    {
        public string Name { get; set; }

        public Bidder(string name)
        {
            Name = name;
        }

        private double BidPrice;

        public void update()
        {
            Console.WriteLine(Name + " propose: " + BidPrice + "\n");

            if (BidPrice > 450)
            {
                Console.WriteLine("Sold!! " + Name);
            }
        }

        public void giveNewPrice(double price)
        {
            BidPrice = price;
        }
    }
}
