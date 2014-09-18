using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Activation;
using TcpConnectionService;

namespace LegoRestService {
	[ServiceBehavior (InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single, IncludeExceptionDetailInFaults = true)]
	[AspNetCompatibilityRequirements (RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class LegoRestService:ILegoRestService {
		private ConnectionObject gantryCraneConnection = new ConnectionObject("192.168.43.142");
		private ConnectionObject truckConnection = new ConnectionObject("192.168.43.142");
		private ConnectionObject reachstackerConnection = new ConnectionObject("192.168.43.142");
		//private Stack<String> messages;
		public string GetClientNameById(string Id) {
			Random r = new Random();
			string ReturnString = "";
			for (int i = 0; i < Convert.ToUInt32 (Id); i++)
				ReturnString += char.ConvertFromUtf32 (r.Next (65, 85));

			return ReturnString;

		}

		public string RSMoveFwd(string units) {
			return reachstackerConnection.sendMessage ("fwd$" + units);
		}

		public string RSMoveBwd(string units) {
			return reachstackerConnection.sendMessage ("bwd$" + units);
		}

		public string RSTurn(string units) {
			return reachstackerConnection.sendMessage ("turn$" + units);
		}

		public string RSLiftArm(string units) {
			return reachstackerConnection.sendMessage ("lift$" + units);
		}

		public string RSLowerArm(string units) {
			return reachstackerConnection.sendMessage ("lower$" + units);
		}

		public string RSExtendArm(string units) {
			return reachstackerConnection.sendMessage ("ext$" + units);
		}

		public string RSRetractArm(string units) {
			return reachstackerConnection.sendMessage ("retr$" + units);
		}

		public string LkwMoveFwd(string units) {
			return truckConnection.sendMessage ("fwd$" + units);
		}

		public string LkwMoveBwd(string units) {
			return truckConnection.sendMessage ("bwd$" + units);
		}

		public string LkwTurn(string units) {
			return truckConnection.sendMessage ("turn$" + units);
		}
	}
}
