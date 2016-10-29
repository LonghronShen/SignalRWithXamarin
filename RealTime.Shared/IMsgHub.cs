using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTime.Shared
{
    public interface IMsgHub
    {
        void Send(string name, string message);
    }
}
