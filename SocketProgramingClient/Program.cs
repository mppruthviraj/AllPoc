using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketProgramingClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TcpClient clientSocket = new TcpClient();
            System.Net.IPAddress localAddress = Dns.GetHostEntry("localhost").AddressList[0];
            try
            {
                clientSocket.Connect(localAddress, 8888);
                Console.WriteLine(" Client >> SuccessFully Connected to server");
                NetworkStream serverStream = clientSocket.GetStream();
                byte[] outStream = Encoding.ASCII.GetBytes("Hi $");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                while (true)
                {
                    if (serverStream.CanRead)
                    {
                        byte[] inStream = new byte[10025];
                        serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
                        string returndata = System.Text.Encoding.ASCII.GetString(inStream);
                        Console.WriteLine("Client>> Recived Message:- {0}", returndata);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Client >> {0}", ex.Message);
                Console.ReadLine();
            }
        }
    }
}
