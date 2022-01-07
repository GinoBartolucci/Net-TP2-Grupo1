<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteCursos.aspx.cs" Inherits="UI.Web.ReporteCursos" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Academia | Reporte Cursos
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style>
        .reporte {
            height: 100%;
            width: 95%;
            margin: auto;
            overflow: auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="reporte">
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <rsweb:ReportViewer ID="ReportesCursos" runat="server" BackColor="" ClientIDMode="AutoID" HighlightBackgroundColor="#CC6699" InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px" LinkActiveColor="" LinkActiveHoverColor="" LinkDisabledColor="" PrimaryButtonBackgroundColor="" PrimaryButtonForegroundColor="" PrimaryButtonHoverBackgroundColor="" PrimaryButtonHoverForegroundColor="" SecondaryButtonBackgroundColor="" SecondaryButtonForegroundColor="" SecondaryButtonHoverBackgroundColor="" SecondaryButtonHoverForegroundColor="" SplitterBackColor="" ToolbarDividerColor="" ToolbarForegroundColor="" ToolbarForegroundDisabledColor="" ToolbarHoverBackgroundColor="" ToolbarHoverForegroundColor="" ToolBarItemBorderColor="" ToolBarItemBorderStyle="Solid" ToolBarItemBorderWidth="1px" ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" ToolBarItemPressedBorderWidth="1px" ToolBarItemPressedHoverBackColor="153, 187, 226" ZoomMode="FullPage" DocumentMapWidth="75%" EnableTheming="True" ExportContentDisposition="AlwaysAttachment" Height="100%" SizeToReportContent="True">
            <LocalReport ReportPath="ReportViewerCursos.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="ReporteCursos" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ReporteCursos" TypeName="Business.Logic.InscripcionLogic">
            <SelectParameters>
                <asp:Parameter Name="idCurso" Type="Object"></asp:Parameter>
                <asp:Parameter Name="orderBy" Type="String"></asp:Parameter>
                <asp:Parameter DefaultValue="" Name="condicion" Type="String"></asp:Parameter>
            </SelectParameters>
        </asp:ObjectDataSource>
    </div>
</asp:Content>
