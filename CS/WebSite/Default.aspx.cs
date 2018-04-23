using System;
using System.IO;
using System.Xml;
using DevExpress.Web.ASPxGridView;
using DevExpress.Web.ASPxGridView.Export;

public partial class _Default : System.Web.UI.Page
{
    protected void GridExporter_RenderBrick(object sender, ASPxGridViewExportRenderingEventArgs e) {
        var dataColumn = e.Column as GridViewDataColumn;
        if(dataColumn != null && dataColumn.FieldName == "ImagePath" && e.RowType == GridViewRowType.Data)
            e.ImageValue = GetImageBinaryData(e.Value.ToString());
    }

    protected void btnPdfExport_Click(object sender, EventArgs e) {
        GridExporter.WritePdfToResponse();
    }
    protected void btnXlsExport_Click(object sender, EventArgs e) {
        GridExporter.WriteXlsToResponse();
    }
    protected void btnXlsxExport_Click(object sender, EventArgs e) {
        GridExporter.WriteXlsxToResponse();
    }
    protected void btnRtfExport_Click(object sender, EventArgs e) {
        GridExporter.WriteRtfToResponse();
    }
    protected void btnCsvExport_Click(object sender, EventArgs e) {
        GridExporter.WriteCsvToResponse();
    }
    byte[] GetImageBinaryData(string relativePath) {
        string path = Server.MapPath(relativePath);
        return File.Exists(path) ? File.ReadAllBytes(path) : null;
    }
}
