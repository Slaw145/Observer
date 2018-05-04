using System;
using System.Collections.Generic;
using System.Text;

namespace FacebookMulithreading
{
    class FacebookPost : Subject
    {
        private List<Observer> observerList;
        private List<string> peoplecommenting;
        static readonly object _locker = new object();
        private static FacebookPost instance = new FacebookPost();

        public static FacebookPost GetInstance()
        {
            return instance;
        }

        public FacebookPost()
        {
            observerList = new List<Observer>();
            peoplecommenting = new List<string>();
        }

        public void addNewNotify()
        {
            lock (_locker)
            {
                Console.WriteLine("Adding new notify");
                notifyObservers();
            }
        }

        public void commentPost(Observer o)
        {
            lock (_locker)
            {
                observerList.Add(o);
                peoplecommenting.Add(o.name);
            }
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
