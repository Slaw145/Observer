using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverEventsExample
{
    delegate void StateChangeHandler(State newState);

    class Product
    {
        private State _state;

        public State MyState
        {
            get { return _state; }
            set
            {
                _state = value;
                _onChange(_state);
            }
        }

        private event StateChangeHandler _onChange;

        public event StateChangeHandler OnStateChange
        {
            add
            {
                _onChange += value;
            }
            remove
            {
                _onChange -= value;
            }
        }
    }
}
