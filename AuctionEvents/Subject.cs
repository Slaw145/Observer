using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionEvents
{
    interface Subject
    {
        void registerBidder(NotifyObserver o);
        void notifyObservers();
    }
}
