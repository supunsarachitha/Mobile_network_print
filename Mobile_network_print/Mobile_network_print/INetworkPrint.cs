using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile_network_print
{
    public interface INetworkPrint
    {
        void SendToPrinter(string val);
    }
}
