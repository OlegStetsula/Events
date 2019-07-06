using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    class Timer
    {
        public delegate void TimerHandler();
        public event TimerHandler TimerStarted;

        public void StartTimer()
        {
            TimerStarted();
        }

    }
}
