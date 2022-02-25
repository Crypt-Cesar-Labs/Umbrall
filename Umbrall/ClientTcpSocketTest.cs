using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Umbrall
{   

    public partial class ClientTcpSocketTest : Form
    {
        public ClientTcpSocketTest()
        {
            InitializeComponent();
        }

        // Variables de conexión
        public string ipAddSocketTest;
        public int portSocketTest;
        public string msgSocketTest;

        // State object for receiving data from remote device
        public class StateObject
        {
            // Client Socket. 
            public Socket workSocket = null;
            // Size of receive buffer.
            public const int BufferSize = 256;
            // Receive buffer.
            public byte[] buffer = new byte[BufferSize];
            // Receive data string. 
            public StringBuilder sb = new StringBuilder();
        }

        // ManualResetEvent instances signal completition
        private static ManualResetEvent connectDone = new ManualResetEvent(false);
        private static ManualResetEvent sendDone = new ManualResetEvent(false);
        private static ManualResetEvent receiveDone = new ManualResetEvent(false);

        //The response for teh remote device 
        private static String response = String.Empty;



        void StartClient()
        {
            // Connect to remote device
            try
            {
                // Establish the remote endpoint for teh socket. 
                IPAddress address = IPAddress.Parse(ipAddSocketTest); //For parse de ip address
                IPEndPoint remoteEP = new IPEndPoint(address, portSocketTest);

                // Create a TCP/IP socket.  
                Socket client = new Socket(address.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                // Connect to the remote endpoint. 
                client.BeginConnect(remoteEP,new AsyncCallback(ConnectCallback), client);
                connectDone.WaitOne();
            } catch (Exception e) 
            {
                Console.WriteLine(e.ToString());
            }
        }
        void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object. 
                Socket client = (Socket)ar.AsyncState;

                // Complete the connection. 
                client.EndConnect(ar);

                Console.WriteLine("Socket connected to {0}", client.RemoteEndPoint.ToString());

                // Signal that the connection has been made. 
                connectDone.Set();
            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
        private void btnConectar_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show(" Ip Address = " + ipAddSocketTest + "\n" +
                            " Port = " + portSocketTest.ToString() + "\n" +
                            " Message = " + msgSocketTest); */

            /////////////////////////////////////////////////////////////
            /////////////////// AsynchronousClient //////////////////////
            /////////////////////////////////////////////////////////////
            


        }
        
        private void txtClientSocketTcpTestAdd_TextChanged(object sender, EventArgs e)
        {

            string ipAddress = txtClientSocketTcpTestAdd.Text;
            ipAddSocketTest = ipAddress;

        }

        private void txtClientSocketTcpTestPort_TextChanged(object sender, EventArgs e)
        {
            int portValue = int.Parse(txtClientSocketTcpTestPort.Text);
            portSocketTest = portValue;
        }

        private void txtClientSocketTcpTestMsg_TextChanged(object sender, EventArgs e)
        {
            string msgText = txtClientSocketTcpTestMsg.Text;
            msgSocketTest = msgText;
        }
    }
}
