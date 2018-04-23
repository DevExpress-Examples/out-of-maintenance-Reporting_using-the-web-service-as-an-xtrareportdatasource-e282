using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace WebApplication1 {
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	public class Service : System.Web.Services.WebService {
		public Service() {
			//Uncomment the following line if using designed components 
			//InitializeComponent(); 
		}

		[WebMethod]
		public string HelloWorld() {
			return "Hello World";
		}
		[WebMethod]
		public ClassLibrary1.DataSet1 FillDS() {
			ClassLibrary1.DataSet1 ds = new ClassLibrary1.DataSet1();
			ds.Tables[0].Rows.Add(new object[] { "AAA", "BBB" });
			ds.Tables[0].Rows.Add(new object[] { "CCC", "DDD" });
			ds.Tables[0].Rows.Add(new object[] { "EEE", "FFF" });
			return ds;
		}

	}
}