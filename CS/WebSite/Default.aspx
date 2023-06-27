<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v22.2" Namespace="DevExpress.Web" TagPrefix="dx" %>





<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td style="padding-right: 4px">
                    <dx:ASPxButton ID="btnPdfExport" runat="server" Text="Export to PDF" OnClick="btnPdfExport_Click" />
                </td>
                <td style="padding-right: 4px">
                    <dx:ASPxButton ID="btnXlsExport" runat="server" Text="Export to XLS" OnClick="btnXlsExport_Click" />
                </td>
                <td style="padding-right: 4px">
                    <dx:ASPxButton ID="btnXlsxExport" runat="server" Text="Export to XLSX" OnClick="btnXlsxExport_Click" />
                </td>
                <td style="padding-right: 4px">
                    <dx:ASPxButton ID="btnRtfExport" runat="server" Text="Export to RTF" OnClick="btnRtfExport_Click" />
                </td>
            </tr>
        </table>
        <dx:ASPxGridView ID="Grid" runat="server" AutoGenerateColumns="False" DataSourceID="XmlDataSource1" 
                         OnExportRenderBrick="Grid_ExportRenderBrick" >
            <Columns>
                <dx:GridViewDataTextColumn FieldName="Common_Name" Caption="Common name" />
                <dx:GridViewDataTextColumn FieldName="Species_Name" Caption="Species name" />
                <dx:GridViewDataImageColumn FieldName="ImagePath" Caption="Image">
                    <PropertiesImage>
                        <ExportImageSettings Width="180" Height="120" />
                    </PropertiesImage>
                </dx:GridViewDataImageColumn>
            </Columns>
            <SettingsPager PageSize="5" />
        </dx:ASPxGridView>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Fishes.xml" />
    </form>
</body>
</html>
