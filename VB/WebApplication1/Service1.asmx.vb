Imports System
Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols

Namespace WebApplication1
	<WebService([Namespace] := "http://tempuri.org/")>
	<WebServiceBinding(ConformsTo := WsiProfiles.BasicProfile1_1)>
	Public Class Service
		Inherits System.Web.Services.WebService

		Public Sub New()
			'Uncomment the following line if using designed components 
			'InitializeComponent(); 
		End Sub

		<WebMethod>
		Public Function HelloWorld() As String
			Return "Hello World"
		End Function
		<WebMethod>
		Public Function FillDS() As ClassLibrary1.DataSet1
			Dim ds As New ClassLibrary1.DataSet1()
			ds.Tables(0).Rows.Add(New Object() { "AAA", "BBB" })
			ds.Tables(0).Rows.Add(New Object() { "CCC", "DDD" })
			ds.Tables(0).Rows.Add(New Object() { "EEE", "FFF" })
			Return ds
		End Function

	End Class
End Namespace