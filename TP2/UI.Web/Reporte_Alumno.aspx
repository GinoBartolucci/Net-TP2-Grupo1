<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reporte_Alumno.aspx.cs" Inherits="UI.Web.Reporte_Alumno" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
   
    <h3>Reporte alumno</h3>
    
    <asp:ScriptManager  runat="server"></asp:ScriptManager>
   
   


    <rsweb:ReportViewer id="Reporte_AlumnoViewer" runat="server" width="900px">
             <LocalReport ReportPath="ReporteAlumno.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="Reporte_AlumnoObjectDataSource" Name="ReporteAlumno" />
                </DataSources>
            </LocalReport>

    </rsweb:ReportViewer>

  

        <asp:ObjectDataSource ID="Reporte_AlunoObjectDataSource" runat="server" SelectMethod="GetReportesDelAlumno" TypeName="Business.Logic.GetReportesDelAlumno" >
            <SelectParameters>
              
                <asp:Parameter Name="AnioEspecialidad" Type="Object"></asp:Parameter>
                <asp:Parameter Name="Estado" Type="string"></asp:Parameter>
                <asp:Parameter Name="DescMateria" Type="string"></asp:Parameter>
                <asp:Parameter Name="DescPlan" Type="string"></asp:Parameter>

            </SelectParameters>
        </asp:ObjectDataSource>

</asp:Content>


