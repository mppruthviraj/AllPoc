using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketProgramingServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Net.IPAddress localAddress = Dns.GetHostEntry("localhost").AddressList[0];
            TcpListener serverSockets = new TcpListener(localAddress,8888);
            int requestCount = 0;
            TcpClient clientSocket = default(TcpClient);
            serverSockets.Start();
            Console.WriteLine(">> Server Started");
            clientSocket = serverSockets.AcceptTcpClient();
            Console.WriteLine(">> Accept connection from client");
            requestCount = 0;
            
            while(true)
            {
                try
                {
                    requestCount = requestCount + 1;
                    NetworkStream networkStream = clientSocket.GetStream();
                    byte[] bytesFrom = new byte[10025];
                    networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                    string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    Console.WriteLine(">>Server:- Data From Client:- {0} ", dataFromClient);
                    string serverResponse = "Last Message from Client:- " + dataFromClient;
                    byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                    networkStream.Write(sendBytes,0,sendBytes.Length);
                    networkStream.Flush();
                    Console.WriteLine(">> Server Response:- {0}", serverResponse);

                }
                catch(Exception ex)
                {
                    Console.WriteLine("Server:- {0}",ex.Message);
                    Console.ReadLine();
                }
            }

            clientSocket.Close();
            serverSockets.Stop();
            Console.WriteLine(">> Exit");
            Console.ReadLine();
        }
    }
}
