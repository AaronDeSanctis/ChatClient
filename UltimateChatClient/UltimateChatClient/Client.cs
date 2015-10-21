using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UltimateChatClient
{
    class Client
    {
        static void SendMessage(String message, NetworkStream stream)
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }
        static string ReceiveMessage(NetworkStream stream)
        {
            Byte[] receivedBytes = new Byte[256];
            Int32 bytes = stream.Read(receivedBytes, 0, receivedBytes.Length);
            String message = String.Empty;
            message = System.Text.Encoding.ASCII.GetString(receivedBytes, 0, bytes);
            return message;
        }
        static NetworkStream Connect(String server)
        {
            try
            {
                Int32 port = 13000;
                TcpClient client = new TcpClient(server, port);
                NetworkStream stream = client.GetStream();
                return stream;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            return null;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                NetworkStream stream = Connect("127.0.0.1");
                SendMessage("message", stream);
                Console.WriteLine(ReceiveMessage(stream));
                Console.ReadLine();
            }
        }
    }
}
