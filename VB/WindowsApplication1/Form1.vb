Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim s As localhost.Service = New WindowsApplication1.localhost.Service()
			Dim rep As New XtraReport1()
			rep.DataSource = s.FillDS()
			rep.ShowPreviewDialog()
		End Sub
	End Class
End Namespace