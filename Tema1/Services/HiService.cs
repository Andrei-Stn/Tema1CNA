using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using Tema1.Protos;

namespace Tema1.Services
{
    public class HiService : Hi.HiBase
    {
        public override Task<HiReply> SayHi(HiRequest request, ServerCallContext context)
        {
            Console.WriteLine("Hi " + request.Name);
            return Task.FromResult(new HiReply());
        }
    }
}
