using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace AH
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class ClientHandler
    {
        TcpListener listener;
        Socket client;
        NetworkStream stream;
        StreamReader reader;
        StreamWriter writer;
        Auctioneer auctioneer;
        

        ClientHandler()
        {
            listener = new TcpListener(IPAddress.Any, 11000);
            auctioneer = new Auctioneer(new Item("auction" , 150));
        }

        public void Start(TcpListener TCP)
        {
            client = listener.AcceptSocket();
            stream = new NetworkStream(client);
            writer = new StreamWriter(stream, Encoding.ASCII);
            writer.AutoFlush = true;
            reader = new StreamReader(stream, Encoding.ASCII);
            Console.WriteLine("Ready");
        }

        public void Send()
        {
            writer.WriteLine();
        }

        public string Receive()
        {
            string input = reader.ReadLine();
            return input;
        }

        public void DoDialog()
        {
            Console.WriteLine("Bidding is starting");
            Console.WriteLine("Current bid is " + auctioneer.Bidding(auctioneer._item._price));
        }


    }

}
