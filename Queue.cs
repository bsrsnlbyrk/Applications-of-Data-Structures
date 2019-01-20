using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Queue
    {
        Data first;
        Data last;

        public Queue()
        {
            first = null;
            last = null;
        }

        bool QueueEmpty()
        {
            if (first == null)
                return true;
            return false;
        }

        public void QueuePush(Data new_element)
        {
            if (!QueueEmpty())

                last.pointer = new_element;

            else

                first = new_element;

            last = new_element;
        }

        public Data QueuePop()
        {
            Data temp = first;

            if (!QueueEmpty())
                first = first.pointer;

            if (first == null)
                last = null;

            return temp;
        }
    }
}
