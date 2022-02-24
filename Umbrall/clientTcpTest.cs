using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Umbrall
{
    public partial class clientTcpTest : Form
    {
        public clientTcpTest()
        {
            InitializeComponent();
        }

        //Clase tomada de referencia
        public class TcpTimeClient
        {
            private const int portNum = 8899;
            private const string hostName = "10.10.100.254";

            internal class Start
            {
                public Start()
                {
                    try
                    {
                        var client = new TcpClient(hostName, portNum);

                        NetworkStream ns = client.GetStream();

                        byte[] bytes = new byte[1024];
                        int bytesRead = ns.Read(bytes, 0, bytes.Length);

                        Console.WriteLine(Encoding.ASCII.GetString(bytes, 0, bytesRead));

                        //client.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }

                }
            }

            
        }
        private void btnClientTcpTestConnect_Click(object sender, EventArgs e)
        {
            //Create a Socket than can be used to communicate on a TCP/IP-based network
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
    }
}
