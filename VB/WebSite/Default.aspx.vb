Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Xml
Imports DevExpress.Web

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub GridExporter_RenderBrick(ByVal sender As Object, ByVal e As ASPxGridViewExportRenderingEventArgs)
		Dim dataColumn = TryCast(e.Column, GridViewDataColumn)
		If dataColumn IsNot Nothing AndAlso dataColumn.FieldName = "ImagePath" AndAlso e.RowType = GridViewRowType.Data Then
			e.ImageValue = GetImageBinaryData(e.Value.ToString())
		End If
	End Sub

	Protected Sub btnPdfExport_Click(ByVal sender As Object, ByVal e As EventArgs)
		GridExporter.WritePdfToResponse()
	End Sub
	Protected Sub btnXlsExport_Click(ByVal sender As Object, ByVal e As EventArgs)
		GridExporter.WriteXlsToResponse()
	End Sub
	Protected Sub btnXlsxExport_Click(ByVal sender As Object, ByVal e As EventArgs)
		GridExporter.WriteXlsxToResponse()
	End Sub
	Protected Sub btnRtfExport_Click(ByVal sender As Object, ByVal e As EventArgs)
		GridExporter.WriteRtfToResponse()
	End Sub
	Protected Sub btnCsvExport_Click(ByVal sender As Object, ByVal e As EventArgs)
		GridExporter.WriteCsvToResponse()
	End Sub
	Private Function GetImageBinaryData(ByVal relativePath As String) As Byte()
		Dim path As String = Server.MapPath(relativePath)
		If File.Exists(path) Then
			Return File.ReadAllBytes(path)
		Else
			Return Nothing
		End If
	End Function
End Class
