using System;
using System.Windows.Media;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer t = new Timer();
            Subscriber s = new Subscriber();
            t.TimerStarted += s.ShowMessage;
            t.StartTimer();
            Console.ReadLine();
            
        }
    }
}
