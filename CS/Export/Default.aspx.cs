using System;
using System.IO;
using DevExpress.Export;
using DevExpress.Web;
using DevExpress.XtraPrinting;

namespace Export {
    public partial class _Default : System.Web.UI.Page {
        protected void Grid_ExportRenderBrick(object sender, ASPxGridViewExportRenderingEventArgs e) {
            var dataColumn = e.Column as GridViewDataColumn;
            if (dataColumn != null && dataColumn.FieldName == "ImagePath" && e.RowType == GridViewRowType.Data)
                e.ImageValue = GetImageBinaryData(e.Value.ToString());
        }

        protected void btnPdfExport_Click(object sender, EventArgs e) {
            Grid.ExportPdfToResponse();
        }
        protected void btnXlsExport_Click(object sender, EventArgs e) {
            Grid.ExportXlsToResponse(new XlsExportOptionsEx() { ExportType = ExportType.WYSIWYG });
        }
        protected void btnXlsxExport_Click(object sender, EventArgs e) {
            Grid.ExportXlsxToResponse(new XlsxExportOptionsEx() { ExportType = ExportType.WYSIWYG });
        }
        protected void btnRtfExport_Click(object sender, EventArgs e) {
            Grid.ExportRtfToResponse();
        }
        byte[] GetImageBinaryData(string relativePath) {
            string path = Server.MapPath(relativePath);
            return File.Exists(path) ? File.ReadAllBytes(path) : null;
        }
    }
}