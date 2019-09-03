Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub chartControl1_ObjectHotTracked(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.HotTrackEventArgs) Handles chartControl1.ObjectHotTracked

		End Sub
		Private selectedSeriesPoint As SeriesPoint
		Private Sub chartControl1_ObjectSelected(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.HotTrackEventArgs) Handles chartControl1.ObjectSelected
			If e.HitInfo.SeriesPoint IsNot Nothing Then
				If selectedSeriesPoint IsNot e.HitInfo.SeriesPoint Then
					selectedSeriesPoint = e.HitInfo.SeriesPoint
					Me.chartControl1.Refresh()
				End If
			End If
		End Sub
		Private Sub chartControl1_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.CustomDrawSeriesPointEventArgs) Handles chartControl1.CustomDrawSeriesPoint
			If e.SeriesPoint Is selectedSeriesPoint Then
				e.SeriesDrawOptions.Color = Color.Red
			End If
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			selectedSeriesPoint = Nothing
		End Sub
	End Class
End Namespace