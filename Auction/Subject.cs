using System;
using System.Collections.Generic;
using System.Text;

namespace Auction
{
    interface Subject
    {
        void registerBidder(Observer o);
        void notifyObservers();
    }
}
