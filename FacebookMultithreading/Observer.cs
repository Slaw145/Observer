using System;
using System.Collections.Generic;
using System.Text;

namespace FacebookMulithreading
{
    interface Observer
    {
        string name { get; set; }
        void update(List<string> peoplecommenting);
    }
}
