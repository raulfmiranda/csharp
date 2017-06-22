using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Servidor
{
	class Program
	{
		public static void Conectar()
		{
			Socket primeiroSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			IPEndPoint direcao = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
			primeiroSocket.Bind(direcao);
			primeiroSocket.Listen(5);
			
			Console.WriteLine("\n Escutando...");
			
			Socket escutar = primeiroSocket.Accept();
			
			Console.WriteLine("\n Conectado com êxito!");
			
			byte[] buffer = new byte[255];
			int tamanho = escutar.Receive(buffer, 0, buffer.Length, 0);
			Array.Resize(ref buffer, tamanho);
			
			Console.WriteLine("\n Cliente disse: " + Encoding.Default.GetString(buffer));
			
			primeiroSocket.Close();
			
		}
		
		public static void Main(string[] args)
		{
			Conectar();
			
			// TODO: Implement Functionality Here
			
			Console.Write("\n\n Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}