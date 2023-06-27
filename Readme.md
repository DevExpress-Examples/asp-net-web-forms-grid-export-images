<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128533193/15.2.17%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4756)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Grid View for ASP.NET Web Forms - How to export images from the column of the GridViewDataImageColumn type
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4756/)**
<!-- run online end -->


The [ASPxGridView](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxGridView) control exports images contained in a column of the [GridViewDataBinaryImageColumn](https://docs.devexpress.com/AspNet/DevExpress.Web.GridViewDataBinaryImageColumn) type.

If your grid displays images in a column of the [GridViewDataImageColumn](https://docs.devexpress.com/AspNet/DevExpress.Web.GridViewDataImageColumn) type, handle the [ExportRenderBrick](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxGridView.ExportRenderBrick) event and assign the image to the [ImageValue](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxGridViewExportRenderingEventArgs.ImageValue) property. 

```cs
protected void Grid_ExportRenderBrick(object sender, ASPxGridViewExportRenderingEventArgs e) {
    var dataColumn = e.Column as GridViewDataColumn;
    if(dataColumn != null && dataColumn.FieldName == "ImagePath" && e.RowType == GridViewRowType.Data)
        e.ImageValue = GetImageBinaryData(e.Value.ToString());
}
```

Note that the [ExportRenderBrick](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxGridView.ExportRenderBrick) event does not fire in [DataAware export mode](https://docs.devexpress.com/AspNet/403941/components/grid-view/concepts/export/export-modes#dataaware-mode), so you should set the export mode to `WYSIWIG`.

```cs
protected void btnXlsExport_Click(object sender, EventArgs e) {
    Grid.ExportXlsToResponse(new XlsExportOptionsEx() { ExportType = ExportType.WYSIWYG });
}
protected void btnXlsxExport_Click(object sender, EventArgs e) {
    Grid.ExportXlsxToResponse(new XlsxExportOptionsEx() { ExportType = ExportType.WYSIWYG });
}
```

## Files to Review

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))

## Documentation

* [Export Grid View Data](https://docs.devexpress.com/AspNet/3791/components/grid-view/concepts/export)

## Technical Demos

* [Export with Data Cell Bands](https://demos.devexpress.com/ASPxGridViewDemos/Exporting/ExportWithDataCellBands.aspx)
