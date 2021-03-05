using System;
using System.Net;
using System.Threading;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace ConsoleApp1
{
    public class WSHandler : WebSocketBehavior
    {
        Timer t;

        protected override void OnOpen()
        {
            base.OnOpen();
            t = new Timer(TimerCallback, null, 1000, 0);
        }

        void TimerCallback(Object o)
        {
            Send("12345678");
            Send("12345678");
        }
    }

    class Program
    {
        static void Main(string[] args)
        { 
            var wssv = new WebSocketServer(IPAddress.Any, 8888);
            wssv.AddWebSocketService<WSHandler>("/svc");
            wssv.Start();
            Console.ReadKey(true);
            wssv.Stop();
        }
    }
}
