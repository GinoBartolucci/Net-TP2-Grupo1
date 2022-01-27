<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reporte_Alumno.aspx.cs" Inherits="UI.Web.Reporte_Alumno" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
   
    <h3>Reporte alumno</h3>

     



    <asp:ScriptManager  runat="server"></asp:ScriptManager>
   
   


    <rsweb:ReportViewer id="Reporte_AlumnoViewer" runat="server" width="100%" BackColor="" ClientIDMode="AutoID" HighlightBackgroundColor="" InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px" LinkActiveColor="" LinkActiveHoverColor="" LinkDisabledColor="" PrimaryButtonBackgroundColor="" PrimaryButtonForegroundColor="" PrimaryButtonHoverBackgroundColor="" PrimaryButtonHoverForegroundColor="" SecondaryButtonBackgroundColor="" SecondaryButtonForegroundColor="" SecondaryButtonHoverBackgroundColor="" SecondaryButtonHoverForegroundColor="" SplitterBackColor="" ToolbarDividerColor="" ToolbarForegroundColor="" ToolbarForegroundDisabledColor="" ToolbarHoverBackgroundColor="" ToolbarHoverForegroundColor="" ToolBarItemBorderColor="" ToolBarItemBorderStyle="Solid" ToolBarItemBorderWidth="1px" ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" ToolBarItemPressedBorderWidth="1px" ToolBarItemPressedHoverBackColor="153, 187, 226">
             <LocalReport ReportPath="ReporteAlumno.rdlc">
 
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="AlumnoDataSet" />
                </DataSources>
     
            </LocalReport>

    </rsweb:ReportViewer>

         


    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetReportesDelAlumno" TypeName="Business.Logic.ReporteAlumnoLogic">
        <SelectParameters>
            <asp:SessionParameter DefaultValue="" Name="idAlumno" SessionField="ID" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>

         


</asp:Content>


