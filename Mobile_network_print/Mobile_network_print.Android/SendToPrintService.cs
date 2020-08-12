using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.IO;
using Java.Net;

namespace Mobile_network_print.Droid
{
    class SendToPrintService
    {
        public void SendToPrinter(string val)
        {
            try
            {
                Socket socket = new Socket("192.168.8.105", 1100);
                // Exmp : Socket socket = new Socket("192.168.0.101", 80);
                PrintWriter oStream = new PrintWriter(socket.OutputStream);
                oStream.Print("\t\t Text to The Printer");
                oStream.Print("\n\n\n");
                oStream.Close();
                socket.Close();

            }
            catch (Exception e)
            {

            }

        }
    }
}