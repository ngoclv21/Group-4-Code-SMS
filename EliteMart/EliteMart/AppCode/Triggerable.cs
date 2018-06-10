using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteMart.AppCode
{
    public interface Triggerable
    {
        void Trigger();
        void Trigger(string screen);
    }
}
