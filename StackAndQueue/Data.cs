using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Data
    {
        public int value;
        public Data pointer;

        public Data(int value)
        {
            this.value = value;
            pointer = null;
        }

    }
}
