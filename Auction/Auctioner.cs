using System;
using System.Collections.Generic;
using System.Text;

namespace Auction
{
    class Auctioneer:Subject
    {
        private List<Observer> observerList;

        public Auctioneer()
        {
            observerList = new List<Observer>();
        }

        public void displayNewBidderPrice()
        {
            notifyObservers();
        }

        public void registerBidder(Observer o)
        {
            observerList.Add(o);
        }

        public void notifyObservers()
        {
            foreach (Observer o in observerList)
            {
                o.update();
            }
        }
    }
}
