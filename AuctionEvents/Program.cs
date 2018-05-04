using System;

namespace AuctionEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Auctioneer auctioner = new Auctioneer();

            Bidder bidder1 = new Bidder("Slawek");
            auctioner.registerBidder(new NotifyObserver(bidder1.update));

            Bidder bidder2 = new Bidder("Charlie");
            auctioner.registerBidder(new NotifyObserver(bidder2.update));

            Bidder bidder3 = new Bidder("Nidhi");
            auctioner.registerBidder(new NotifyObserver(bidder3.update));

            bidder1.giveNewPrice(123);
            bidder2.giveNewPrice(158);
            bidder3.giveNewPrice(208);

            auctioner.displayNewBidderPrice();

            bidder1.giveNewPrice(243);
            bidder2.giveNewPrice(358);
            bidder3.giveNewPrice(458);

            auctioner.displayNewBidderPrice();

            Console.ReadKey();
        }
    }
}
