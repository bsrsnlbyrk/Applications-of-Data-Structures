using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Stack
    {
        Data top;
         
        public Stack()
        {
            top = null;
        }

        public bool StackEmpty()
        {
            if (top == null)
            
                return true;

            return false;
        }

        public void StackPush(Data new_element)
        {
            new_element.pointer = top;
            top = new_element;
        }

        public Data StackPop()
        {
            Data temp = top;
            if (!StackEmpty())
            {
                top = top.pointer;
            }
            return temp;
        }

    }
}
