﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client ready");

            

            TcpClient client = new TcpClient(IPAddress.Any , 11000);
            NetworkStream stream = client.GetStream();
            StreamWriter writer = new StreamWriter(stream);
            StreamReader reader = new StreamReader(stream);

            while (true)
            {
            }
        }
    }
}
