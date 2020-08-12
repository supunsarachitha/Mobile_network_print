
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mobile_network_print
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnPrint_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtHostIp.Text) || string.IsNullOrEmpty(txtHostIp.Text))
                {
                    return;
                }

                ///direct print
                try
                {
                    string ipAddress = txtHostIp.Text.ToString(); //ie: 10.0.0.91
                    int port = Convert.ToInt32(txtport.Text.ToString()); //ie: 9100

                    IPHostEntry IPHost = Dns.GetHostEntry(ipAddress);
                    string[] aliases = IPHost.Aliases;
                    IPAddress[] addr = IPHost.AddressList;

                    EndPoint ep = new IPEndPoint(addr[0], port);
                    Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    sock.Connect(ep);
                    NetworkStream ns = new NetworkStream(sock);
                    String transferType = "^MTT";// Sets the type to thermal transfer
                    String ZPLString = "^LH5,5" + transferType +
                    "^BY2" + "^MNM" +
                    "^FO50,30" + "^ADN,96,20^FD" + "blabla" + "^FS" +
                    "^FO250,130" + "^BCN,70,N,N,N" + "^FD" +
                    "BarCode1" + "^FS" +
                    "^FO50,230" + "^ADN,96,20^FD" + " BarCode2" + "^FS";
                    ZPLString = "^XA" + ZPLString + "^XZ";
                    byte[] toSend = Encoding.ASCII.GetBytes("Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.");
                    ns.Write(toSend, 0, toSend.Length);

                    ns.Close();
                    ns.Flush();


                    sock.Close();
                }
                catch (Exception ex)
                {
                }
            }
            catch (Exception ex)
            {

                return;
            }



        }
    }
}
