using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Projekt
{
    class Trigger
    {
        int threshold;
        bool active;

        public int Threshold
        {
            set
            {
                threshold = value;
                Count = value;
            }

            private get
            {
                return threshold;
            }
        }

        int Count;

        public delegate void TriggerEventHandler();
        public event TriggerEventHandler Triggered;

        public Trigger() : this(1) { }

        public Trigger(int threshold)
        {
            Threshold = threshold;
            Stop();
        }

        public void Tick()
        {
            if (Count == 0 && active)
            {
                Count = Threshold;
                Triggered?.Invoke();
                return;
            }
            else if (active)
            {
                Count--;
            }
        }

        public void Start()
        {
            active = true;
        }

        public void Stop()
        {
            active = false;
            Count = Threshold;
        }
    }
}
