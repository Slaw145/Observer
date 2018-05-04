using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverSchema
{
    interface Observer
    {
        string name { get; set; }
        void update(List<string> peoplecommenting);
    }
}
