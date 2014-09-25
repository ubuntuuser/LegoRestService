using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LegoRestService {
	public static class Routing {
		public const string GetClientRoute = "/Client/{id}";
		public const string RSMoveFwd = "/reachstacker/move/fwd/{units}";
		public const string RSMoveBwd = "/reachstacker/move/bwd/{units}";
		public const string RSTurn = "/reachstacker/move/turn/{units}";
		public const string RSLiftArm = "/reachstacker/arm/lift/{units}";
		public const string RSLowerArm = "/reachstacker/arm/lower/{units}";
		public const string RSExtendArm = "/reachstacker/arm/extend/{units}";
		public const string RSRetractArm = "/reachstacker/arm/retract/{units}";
		public const string RSgetContainerFromTruck = "/reachstacker/get/truck";
		public const string RSgetContainerFromStorage = "/reachstacker/get/storage";
		public const string RSdropContainerOnTruck = "/reachstacker/put/truck";
		public const string RSdropContainerOnStorage = "/reachstacker/put/storage";
		public const string RSreset = "/reachstacker/reset";
		public const string TruckMoveFwd = "/truck/move/fwd/{units}";
		public const string TruckMoveBwd = "/truck/move/bwd/{units}";
		public const string TruckTurn = "/truck/turn/{units}";
		public const string TruckGoToLoading = "/truck/goto/loading";
		public const string TruckGoToStart = "/truck/goto/start";
		public const string TruckGoToEnd = "/truck/goto/end";
		public const string GCgetContainerFromShip = "/gantrycrane/get/ship";
		public const string GCgetContainerFromStorage = "/gantrycrane/get/storage";
		public const string GCgetContainerFromTrain = "/gantrycrane/get/train";
		public const string GCdropContainerOnShip = "/gantrycrane/put/ship";
		public const string GCdropContainerOnStorage = "/gantrycrane/put/storage";
		public const string GCdropContainerOnTrain = "/gantrycrane/put/train";
		public const string GCreset = "/gantrycrane/reset";
	}
}
