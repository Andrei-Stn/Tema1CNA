// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Hi.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Tema1.Protos {
  public static partial class Hi
  {
    static readonly string __ServiceName = "hi.Hi";

    static readonly grpc::Marshaller<global::Tema1.Protos.HiRequest> __Marshaller_hi_HiRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tema1.Protos.HiRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Tema1.Protos.HiReply> __Marshaller_hi_HiReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tema1.Protos.HiReply.Parser.ParseFrom);

    static readonly grpc::Method<global::Tema1.Protos.HiRequest, global::Tema1.Protos.HiReply> __Method_SayHi = new grpc::Method<global::Tema1.Protos.HiRequest, global::Tema1.Protos.HiReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayHi",
        __Marshaller_hi_HiRequest,
        __Marshaller_hi_HiReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Tema1.Protos.HiReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Hi</summary>
    public partial class HiClient : grpc::ClientBase<HiClient>
    {
      /// <summary>Creates a new client for Hi</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public HiClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Hi that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public HiClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected HiClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected HiClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Tema1.Protos.HiReply SayHi(global::Tema1.Protos.HiRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHi(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Tema1.Protos.HiReply SayHi(global::Tema1.Protos.HiRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SayHi, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Tema1.Protos.HiReply> SayHiAsync(global::Tema1.Protos.HiRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHiAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Tema1.Protos.HiReply> SayHiAsync(global::Tema1.Protos.HiRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SayHi, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override HiClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new HiClient(configuration);
      }
    }

  }
}
#endregion
