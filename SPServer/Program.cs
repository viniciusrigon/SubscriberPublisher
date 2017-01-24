using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;


namespace SPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            int portaSubServer = 51100;
            int portaTopico = 51200;
            int portaTitulo = 51300;

            Socket meuSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            TcpListener listener = new TcpListener(portaTopico);
            

            
        }

        
    }
}
