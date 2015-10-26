using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UltimateChatListener
{
    class Listener
    {
        TcpListener server = null;
        
        public static void SendMessage(String message, NetworkStream stream)
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }
        public static string ReceiveMessage(NetworkStream stream)
        {
            Byte[] receivedBytes = new Byte[256];
            Int32 bytes = stream.Read(receivedBytes, 0, receivedBytes.Length);
            String message = String.Empty;
            message = System.Text.Encoding.ASCII.GetString(receivedBytes, 0, bytes);
            return message;
        }
        public NetworkStream Connect()
        {
            try
            {
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                Int32 port = 13000;
                TcpListener listener = new TcpListener(localAddr, port);
                listener.Start();
                TcpClient client = listener.AcceptTcpClient();
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
        //public static void Main(string[] args)
        //{
        //    NetworkStream stream = Connect("127.0.0.1"); 
        //}
        //static NetworkStream Connect(String server)
        //{
        //    //TcpListener server = null;
        //    Int32 port = 13000;
        //    server = new TcpListener(server, port);
        //    TcpClient client = server.AcceptTcpClient();
        //    NetworkStream stream = client.GetStream();
        //    //stream.Start();
            
        //}
     
        //static string ReceiveMessage(, NetworkStream stream) 
        //{
        //    Byte[] bytes = new Byte[256];
        //    String data = null;
        //    int i;
        //     while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
        //        {
        //        data = System.Text.Encoding.ASCII.GetBytes()
        //        Console.WriteLine("Received: {0}", data);
        //        return data;
        //        }
        //     return data;
        //    }
        //    static void SendMessage(NetworkStream stream, String data)
        //    {
        //        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
        //        stream.Write(msg, 0, msg.Length);
        //        Console.WriteLine("Sent: {0}", data);
        //}
    }
}
            //try
            
                // Set the TcpListener on port 13000.
                

                // Buffer for reading data
               

                // Enter the listening loop.
                //while (true)
                //{
                    

                    // Perform a blocking call to accept requests.
                    // You could also user server.AcceptSocket() here.
                    //TcpClient client = server.AcceptTcpClient();
                    

                    //data = null;

                    // Get a stream object for reading and writing
                    //NetworkStream stream = client.GetStream();

                    //int i;

                    //// Loop to receive all the data sent by the client.
                    //while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    //{
                        // Translate data bytes to a ASCII string.
                        

                        // Process the data sent by the client.
                        






                        
                    

                   
                    
                
            //}
            //catch (SocketException e)
            //{
            //    Console.WriteLine("SocketException: {0}", e);
            //}
            //finally
            //{
                // Stop listening for new clients.
                //server.Stop();
            //}
           

            //Console.WriteLine("\nHit enter to continue...");
            //Console.Read();
        
         

