using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace LegoRestService {
	[ServiceContract (Name = "RESTDemoServices")]
	public interface ILegoRestService {
		[OperationContract]
		[WebGet (UriTemplate = Routing.GetClientRoute, BodyStyle = WebMessageBodyStyle.Bare)]
		string GetClientNameById (string Id);

		[OperationContract]
		[WebGet (UriTemplate = Routing.RSMoveFwd, BodyStyle = WebMessageBodyStyle.Bare)]
		string RSMoveFwd (string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.RSMoveBwd, BodyStyle = WebMessageBodyStyle.Bare)]
		string RSMoveBwd (string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.RSTurn, BodyStyle = WebMessageBodyStyle.Bare)]
		string RSTurn (string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.RSLiftArm, BodyStyle = WebMessageBodyStyle.Bare)]
		string RSLiftArm (string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.RSLowerArm, BodyStyle = WebMessageBodyStyle.Bare)]
		string RSLowerArm (string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.RSExtendArm, BodyStyle = WebMessageBodyStyle.Bare)]
		string RSExtendArm (string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.RSgetContainerFromTruck, BodyStyle = WebMessageBodyStyle.Bare)]
		string RSgetContainerFromTruck (string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.RSgetContainerFromStorage, BodyStyle = WebMessageBodyStyle.Bare)]
		string RSgetContainerFromStorage (string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.RSdropContainerOnTruck, BodyStyle = WebMessageBodyStyle.Bare)]
		string RSdropContainerOnTruck (string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.RSdropContainerOnStorage, BodyStyle = WebMessageBodyStyle.Bare)]
		string RSdropContainerOnStorage (string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.RSreset, BodyStyle = WebMessageBodyStyle.Bare)]
		string RSreset (string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.RSRetractArm, BodyStyle = WebMessageBodyStyle.Bare)]
		string RSRetractArm (string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.TruckMoveFwd, BodyStyle = WebMessageBodyStyle.Bare)]
		string TruckMoveFwd (string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.TruckMoveBwd, BodyStyle = WebMessageBodyStyle.Bare)]
		string TruckMoveBwd (string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.TruckTurn, BodyStyle = WebMessageBodyStyle.Bare)]
		string TruckTurn (string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.TruckGoToStart, BodyStyle = WebMessageBodyStyle.Bare)]
		string TruckGoToStart ();

		[OperationContract]
		[WebGet (UriTemplate = Routing.TruckGoToLoading, BodyStyle = WebMessageBodyStyle.Bare)]
		string TruckGoToLoading ();

		[OperationContract]
		[WebGet (UriTemplate = Routing.TruckGoToEnd, BodyStyle = WebMessageBodyStyle.Bare)]
		string TruckGoToEnd ();

		[OperationContract]
		[WebGet (UriTemplate = Routing.GCgetContainerFromShip, BodyStyle = WebMessageBodyStyle.Bare)]
		string GCgetContainerFromShip ();

		[OperationContract]
		[WebGet (UriTemplate = Routing.GCgetContainerFromStorage, BodyStyle = WebMessageBodyStyle.Bare)]
		string GCgetContainerFromStorage ();

		[OperationContract]
		[WebGet (UriTemplate = Routing.GCgetContainerFromTrain, BodyStyle = WebMessageBodyStyle.Bare)]
		string GCgetContainerFromTrain ();

		[OperationContract]
		[WebGet (UriTemplate = Routing.GCdropContainerOnShip, BodyStyle = WebMessageBodyStyle.Bare)]
		string GCdropContainerOnShip ();

		[OperationContract]
		[WebGet (UriTemplate = Routing.GCdropContainerOnStorage, BodyStyle = WebMessageBodyStyle.Bare)]
		string GCdropContainerOnStorage ();

		[OperationContract]
		[WebGet (UriTemplate = Routing.GCdropContainerOnTrain, BodyStyle = WebMessageBodyStyle.Bare)]
		string GCdropContainerOnTrain ();

		[OperationContract]
		[WebGet (UriTemplate = Routing.GCreset, BodyStyle = WebMessageBodyStyle.Bare)]
		string GCreset ();
	}
}
