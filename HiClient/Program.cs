using System;
using Grpc.Net.Client;
using Tema1.Protos;

namespace HiClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Hi.HiClient(channel);

            Console.Write("Please enter your name: ");

            var request = new HiRequest();
            request.Name = Console.ReadLine();

            client.SayHi(request);

            channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
