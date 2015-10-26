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
        NetworkStream stream;
        public String message;
        public Client()
        {
            message = "hi";
        }
        public void Connect(String server)
        {
            try
            {
                Int32 port = 13000;
                TcpClient client = new TcpClient(server, port);
                stream = client.GetStream();
                //return stream;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
                //return null;
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
                //return null;
            }

        }
        public void SendMessage()
        {
            while (true)
            {
                try
                {
                    Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                }
                catch
                {

                }
            }
        }
       
        public void ReceiveMessage()
        {
            while (true)
            {
                try
                {


                    Byte[] receivedBytes = new Byte[256];
                    Int32 bytes = stream.Read(receivedBytes, 0, receivedBytes.Length);
                    String message = String.Empty;
                    message = System.Text.Encoding.ASCII.GetString(receivedBytes, 0, bytes);

                }

                catch
                {

                }
            }
        }
        
        //static void Main(string[] args)
        //{
        //    while (true)
        //    {
        //        NetworkStream stream = Connect("127.0.0.1");
        //        SendMessage("message", stream);
        //        Console.WriteLine(ReceiveMessage(stream));
        //        Console.ReadLine();
        //    }
        //}
    }
}
