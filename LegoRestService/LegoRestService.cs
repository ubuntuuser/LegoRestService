using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Activation;
using TcpConnectionService;
using System.ServiceModel.Web;
using System.Threading;

namespace LegoRestService {
	[ServiceBehavior (InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single, IncludeExceptionDetailInFaults = true)]
	[AspNetCompatibilityRequirements (RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class LegoRestService:ILegoRestService {
		private ConnectionObject gantryCraneConnection = new ConnectionObject ("10.0.0.3");
		private ConnectionObject truckConnection = null;
		// new ConnectionObject ("10.0.0.5");
		private ConnectionObject reachstackerConnection = null;
		//new ConnectionObject ("10.0.0.4");
		//private Stack<String> messages;
		public string GetClientNameById (string Id) {
			Random r = new Random ();
			string ReturnString = "";
			for (int i = 0; i < Convert.ToUInt32 (Id); i++)
				ReturnString += char.ConvertFromUtf32 (r.Next (65, 85));

			return ReturnString;

		}

		static void Main (string[] args) {
			LegoRestService DemoServices = new LegoRestService ();
			WebServiceHost _serviceHost = new WebServiceHost (DemoServices, new Uri ("http://localhost:8000/DEMOService"));
			_serviceHost.Open ();
			Console.ReadKey ();
			_serviceHost.Close ();
		}

		public string RSMoveFwd (string units) {
			return reachstackerConnection.sendMessage ("fwd$" + units);
		}

		public string RSMoveBwd (string units) {
			return reachstackerConnection.sendMessage ("bwd$" + units);
		}

		public string RSTurn (string units) {
			return reachstackerConnection.sendMessage ("turn$" + units);
		}

		public string RSLiftArm (string units) {
			return reachstackerConnection.sendMessage ("lift$" + units);
		}

		public string RSLowerArm (string units) {
			return reachstackerConnection.sendMessage ("lower$" + units);
		}

		public string RSExtendArm (string units) {
			return reachstackerConnection.sendMessage ("ext$" + units);
		}

		public string RSRetractArm (string units) {
			return reachstackerConnection.sendMessage ("retr$" + units);
		}

		public string RSgetContainerFromTruck (string units) {
			return reachstackerConnection.sendMessage ("getFromTruck$");
		}

		public string RSgetContainerFromStorage (string units) {
			return reachstackerConnection.sendMessage ("getFromStorage$");
		}

		public string RSdropContainerOnTruck (string units) {
			return reachstackerConnection.sendMessage ("dropOnTruck$");
		}

		public string RSdropContainerOnStorage (string units) {
			return reachstackerConnection.sendMessage ("dropOnStorage$");
		}

		public string RSreset (string units) {
			return reachstackerConnection.sendMessage ("reset$");
		}

		public string TruckMoveFwd (string units) {
			return truckConnection.sendMessage ("fwd$" + units);
		}

		public string TruckMoveBwd (string units) {
			return truckConnection.sendMessage ("bwd$" + units);
		}

		public string TruckTurn (string units) {
			return truckConnection.sendMessage ("turn$" + units);
		}

		public string TruckGoToStart () {
			return truckConnection.sendMessage ("goToStart$");
		}

		public string TruckGoToEnd () {
			return truckConnection.sendMessage ("goToEnd$");
		}

		public string TruckGoToLoading () {
			return truckConnection.sendMessage ("goToLoading$");
		}

		public string GCgetContainerFromShip () {
			return gantryCraneConnection.sendMessage ("getContainerFromShip$");
		}

		public string GCgetContainerFromStorage () {
			return gantryCraneConnection.sendMessage ("getContainerFromStorage$");
		}

		public string GCgetContainerFromTrain () {
			return gantryCraneConnection.sendMessage ("getContainerFromTrain$");
		}

		public string GCdropContainerOnShip () {
			return gantryCraneConnection.sendMessage ("dropContainerOnShip$");
		}

		public string GCdropContainerOnStorage () {
			return gantryCraneConnection.sendMessage ("dropContainerOnStorage$");
		}

		public string GCdropContainerOnTrain () {
			return gantryCraneConnection.sendMessage ("dropContainerOnTrain$");
		}

		public string GCreset () {
			return gantryCraneConnection.sendMessage ("reset$");
		}
	}
}
