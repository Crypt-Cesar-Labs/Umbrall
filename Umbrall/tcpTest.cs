using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Umbrall
{
    public partial class tcpTest : Form
    {
        public tcpTest()
        {
            InitializeComponent();
        }

        public class NetworkServer
        {
            public void Start()
            {
                //Creamos un TcpListener y le indicamos que puerto
                //va a poner en escucha
                TcpListener tcpListener = new TcpListener(9898);

                //Iniciamos la escucha
                tcpListener.Start();

                //este metodo queda blouqeado hasta que se conecte un cliente
                Socket socketForClient = tcpListener.AcceptSocket();

                if(socketForClient.Connected)
                {
                    //Si se conecta
                    Console.WriteLine("Cliente conectado.");

                    //Creamos el networkStream, el reader y el writing
                    NetworkStream networkStream = new NetworkStream(socketForClient);
                    StreamWriter streamWriter = new StreamWriter(networkStream);
                    StreamReader streamReader = new StreamReader(networkStream);

                    //Esta es la data a enviar
                    string theString = "Esta es la data de envio";

                    try
                    {
                        //Escribamos la data en el stream
                        streamWriter.WriteLine(theString);

                        //Ahora le decimos que la mande
                        streamWriter.Flush();

                        //Esperamos data del cliente
                        //y la escribimos por consola
                        theString = streamReader.ReadLine();
                        Console.WriteLine(theString);
                    }
                    finally
                    {
                        //Cerramos las conexiones
                        streamReader.Close();
                        streamWriter.Close();
                        networkStream.Close();
                        socketForClient.Close();
                    }
                }
            }
        }

        private void btnServerTcpConnect_Click(object sender, EventArgs e)
        {
            
            new Thread(new ThreadStart( delegate { new NetworkServer().Start();})).Start();
        }

        private void btnClientTcpConnect_Click(object sender, EventArgs e)
        {

        }
    }
}
