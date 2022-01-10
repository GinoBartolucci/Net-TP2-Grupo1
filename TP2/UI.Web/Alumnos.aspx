<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alumnos.aspx.cs" Inherits="UI.Web.Alumnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <h2>Alumnos</h2>
    <hr/>
               <asp:Panel ID ="gridPanel" runat ="server"  Visible ="false"> 
            <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
                SelectedRowStyle-BackColor="Black"
                SelectedRowStyle-ForeColor="White" 
                DataKeynames ="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" 
               >
 
                <SelectedRowStyle BackColor="Black" ForeColor="White" />
                 
                <Columns>
                    <asp:BoundField  HeaderText ="ID" DataField ="ID" />
                    <asp:BoundField HeaderText ="Legajo" DataField ="Legajo" />
                    <asp:BoundField HeaderText ="Nombre" DataField ="Nombre" />
                    <asp:BoundField HeaderText ="Apellido" DataField ="Apellido" />
                    <asp:BoundField HeaderText ="Telefono" DataField ="FechaNacimiento" />
                    <asp:BoundField HeaderText ="Email" DataField ="FechaNacimiento" />
                    <asp:CommandField HeaderText ="Opciones" ShowSelectButton ="True"/>

                </Columns>

            </asp:GridView>
              </asp:Panel>
    <asp:Button class="mdc-button mdc-button--raised" runat="server" Text="Agregar" />
</asp:Content>
