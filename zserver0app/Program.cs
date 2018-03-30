using System;

using Trinity;
using Trinity.Core.Lib;
using Trinity.Network;

namespace zserver0app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //TrinityConfig.ServerPort = 8081;
            TrinityConfig.HttpPort = 8080;

            TrinityServer server = new TrinityServer();
            // server.RegisterCommunicationModule<FanoutSearchModule>();
            server.Start();
        }
    }
}
