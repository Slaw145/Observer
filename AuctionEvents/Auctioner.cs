using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionEvents
{
    public delegate void NotifyObserver();

    public class Auctioneer: Subject
    {
        public event NotifyObserver NotifyObserverEvent;
        
        public void registerBidder(NotifyObserver ob)
        {
            NotifyObserverEvent += ob;
        }

        public void displayNewBidderPrice()
        {
            notifyObservers();
        }

        public void notifyObservers()
        {
            NotifyObserverEvent();
        }
    }
}
