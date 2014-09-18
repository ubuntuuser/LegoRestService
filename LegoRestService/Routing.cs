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
		public const string LkwMoveFwd = "/lkw/move/fwd/{units}";
		public const string LkwMoveBwd = "/lkw/move/bwd/{units}";
		public const string LkwTurn = "/lkw/turn/{units}";
	}
}
