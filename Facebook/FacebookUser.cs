using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverSchema
{
    class FacebookUser : Observer
    {
        public string name { get;set; }
        string people;

        public FacebookUser(string name)
        {
            this.name = name;
        }

        public void update(List<string> peoplecommenting)
        {
            peoplecommenting.Remove(name);

            foreach (string o in peoplecommenting)
            {
                people += o+" ";
            }

            if(peoplecommenting.Count>0)
            {
                Console.WriteLine("Hello " + name + "!");
                Console.WriteLine(people + "also commented the post\n");
            }
            
        }
    }
}
