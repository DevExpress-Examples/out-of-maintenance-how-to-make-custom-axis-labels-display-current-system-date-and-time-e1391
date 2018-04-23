Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace CustomLabelsText
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim coll As CustomAxisLabelCollection = (CType(Me.chartControl1.Diagram, XYDiagram)).AxisX.CustomLabels
			coll(0).Name = DateTime.Today.DayOfWeek.ToString()
			coll(1).Name = DateTime.Today.AddDays(4).DayOfWeek.ToString()
		End Sub

	End Class
End Namespace