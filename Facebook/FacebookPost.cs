using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverSchema
{
    class FacebookPost : Subject
    {
        private List<Observer> observerList;
        private List<string> peoplecommenting;

        public FacebookPost()
        {
            observerList = new List<Observer>();
            peoplecommenting = new List<string>();
        }

        public void addNewNotify()
        {
            Console.WriteLine("Adding new notify");
            notifyObservers();
        }

        public void commentPost(Observer o)
        {
            observerList.Add(o);
            peoplecommenting.Add(o.name);
            
        }

        public void notifyObservers()
        {
            foreach (Observer o in observerList)
            {
                o.update(peoplecommenting);
            }
        }
    }
}
