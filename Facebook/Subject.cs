using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverSchema
{
    interface Subject
    {
        void commentPost(Observer o);
        void notifyObservers();
    }
}
