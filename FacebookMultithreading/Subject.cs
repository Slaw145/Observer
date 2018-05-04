using System;
using System.Collections.Generic;
using System.Text;

namespace FacebookMulithreading
{
    interface Subject
    {
        void commentPost(Observer o);
        void notifyObservers();
    }
}
