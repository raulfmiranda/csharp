/*
 * Trabalhando com soquetes no C#(csharp):
 * http://www.devmedia.com.br/trabalhando-com-soquetes-no-c-csharp/4356
 * 
 * Transferindo arquivos usando Sockets:
 * http://www.macoratti.net/14/06/c_sock1.htm
 * 
 */
 
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Cliente
{
	class Program
	{
		public static void Conectar()
		{
			Socket primeiroSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			IPEndPoint direcao = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
			primeiroSocket.Connect(direcao);
			
			Console.WriteLine("\n Conectado com êxito!");
			Console.Write("\n Digite informação a ser enviada: ");
			
			string info = Console.ReadLine();
			byte[] infoEnviar = Encoding.Default.GetBytes(info);
			primeiroSocket.Send(infoEnviar, 0, infoEnviar.Length, 0);
			
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