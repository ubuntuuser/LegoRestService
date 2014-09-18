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
		string GetClientNameById(string Id);

		[OperationContract]
		[WebGet (UriTemplate = Routing.RSMoveFwd, BodyStyle = WebMessageBodyStyle.Bare)]
		string RSMoveFwd(string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.RSMoveBwd, BodyStyle = WebMessageBodyStyle.Bare)]
		string RSMoveBwd(string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.RSTurn, BodyStyle = WebMessageBodyStyle.Bare)]
		string RSTurn(string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.RSLiftArm, BodyStyle = WebMessageBodyStyle.Bare)]
		string RSLiftArm(string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.RSLowerArm, BodyStyle = WebMessageBodyStyle.Bare)]
		string RSLowerArm(string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.RSExtendArm, BodyStyle = WebMessageBodyStyle.Bare)]
		string RSExtendArm(string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.RSRetractArm, BodyStyle = WebMessageBodyStyle.Bare)]
		string RSRetractArm(string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.LkwMoveFwd, BodyStyle = WebMessageBodyStyle.Bare)]
		string LkwMoveFwd(string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.LkwMoveBwd, BodyStyle = WebMessageBodyStyle.Bare)]
		string LkwMoveBwd(string units);

		[OperationContract]
		[WebGet (UriTemplate = Routing.LkwTurn, BodyStyle = WebMessageBodyStyle.Bare)]
		string LkwTurn(string units);
	}
}
