<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" MasterPageFile="~/Site.Master" Inherits="UI.Web.Home"  %>
   
      
 
 <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

    <br />
    
    <section class="container">
        <style>
            .label-top
            {
                display:block;
                margin-bottom:2px;
            }
        </style>
    
        <asp:Label cssClass="label-top" runat="server" id="nombreAlumno" Font-Size="24px" >NombreAlumno</asp:Label>
        <asp:Label cssClass="label-top" runat="server" id="especialidadAlumno" Font-Size="20px" ForeColor="Gray" >Estudiante de Lorem impsum</asp:Label>
        <asp:Label cssClass="label-top" runat="server" id="planAlumno" Font-Size="18px" ForeColor="Gray" >Plan IMPSUM</asp:Label>
        <hr />
        <br />
        

 
    
       
    </section>

  
    
      
</asp:Content>
