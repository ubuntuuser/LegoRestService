using System;
using System.Net.Sockets;
using System.Threading;

namespace TcpConnectionService {
	public class ConnectionObject {
		private bool connected = false;
		TcpClient mySocket = null;
		string ipAddress = String.Empty;
		int port = 8888;

		public int Port {
			get {
				return port;
			}
			set {
				port = value;
			}
		}

		public ConnectionObject (string ipAddress) {
			this.ipAddress = ipAddress;
			this.initialize ();
		}

		public bool isConnected () {
			return connected;
		}

		public void connect () {
			initialize ();
		}

		public void disconnect () {
			if (connected) {
				mySocket.Close ();
			}
		}

		private bool initialize () {
			if (mySocket == null)
				mySocket = new System.Net.Sockets.TcpClient ();
			try {
				mySocket.Connect (ipAddress, port);
				connected = true;
				return true;
			} catch (System.Net.Sockets.SocketException e) {
				Console.WriteLine ("Unable to connect, check if the brick is up and has the correct IP");
				//Console.WriteLine (e.ToString ());
			} catch (Exception e) {
				Console.WriteLine ("Some exception happened: " + e.ToString ());
			}
			return false;
		}

		public string sendMessage (string message) {
			int connectionCounter = 0;
			bool continuing = false;
			if (mySocket == null) {
				continuing = initialize ();
			}
			while (!mySocket.Connected && connectionCounter < 4) {
				continuing = initialize ();
				++connectionCounter;
				Thread.Sleep (2000);
			}
			if (mySocket.Connected)
				continuing = true;
			if (connectionCounter == 3 || !continuing) {
				System.Console.WriteLine ("Unable to connect");
				connectionCounter = 0;

				return "Error";
			}
			NetworkStream serverStream = mySocket.GetStream ();
			System.Console.WriteLine (message);
			byte[] outStream = System.Text.Encoding.ASCII.GetBytes (message);
			serverStream.Write (outStream, 0, outStream.Length);

			byte[] inStream = new byte[1000025];
			Console.WriteLine (mySocket.ReceiveBufferSize.ToString ());
			serverStream.Read (inStream, 0, (int)mySocket.ReceiveBufferSize);
			string returndata = System.Text.Encoding.ASCII.GetString (inStream);
			Console.WriteLine (returndata);
			return "done";
		}
	}
}

