<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Comisiones.aspx.cs"  MasterPageFile="~/Site.Master" Inherits="UI.Web.Comisiones" %>

 <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
     
 <div> 
            <asp:Panel ID ="gridPanel" runat ="server"  Visible ="false"> 
            <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
                SelectedRowStyle-BackColor="Black"
                SelectedRowStyle-ForeColor="White" 
                DataKeynames ="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" 
               >
 
                <SelectedRowStyle BackColor="Black" ForeColor="White" />
                
                <Columns>
                    <asp:BoundField  HeaderText ="Descripcion" DataField ="DescComision" />
                    <asp:BoundField HeaderText ="Anio Especialidad" DataField ="AnioEspecialidad" />
                    <asp:BoundField HeaderText ="ID Plan" DataField ="IdPlan" />
                    <asp:CommandField HeaderText ="Seleccionar" ShowSelectButton ="True"/>

                </Columns>

            </asp:GridView>
              </asp:Panel>

            <asp:Panel id="panelAlumnosDocentes" runat="server"> 
                <asp:GridView ID="gridViewDocenteAlumno" runat="server" AutoGenerateColumns="False"  
                   DataKeynames ="ID" >
 
                <SelectedRowStyle BackColor="Black" ForeColor="White" />
                
                <Columns>
                    <asp:BoundField HeaderText ="Descripcion" DataField ="DescComision" />
                    <asp:BoundField HeaderText ="Anio Especialidad" DataField ="AnioEspecialidad" />
                    <asp:BoundField HeaderText ="ID Plan" DataField ="IdPlan" />
                </Columns>
 
            </asp:GridView>
            </asp:Panel>

           


            <asp:Panel ID="formPanel" runat="server" Visible ="false">
                <asp:Label ID="descripcionLabel" runat="server" Text="Descripcion"></asp:Label>
                <asp:TextBox ID="descripcionTextBox" runat="server"></asp:TextBox>


                <asp:Label ID="descripcionValidacion" runat="server" Text="*" ForeColor="#CC3300"></asp:Label>
                <br />
                <asp:Label ID="anioEspecialidadLabel" runat="server" Text="Anio Especialidad"></asp:Label>
                <asp:TextBox ID="anioEspecialidadTextBox" runat="server"></asp:TextBox>
                <asp:Label ID="anioEspecialidadValidacion" runat="server" Text="*" ForeColor="#CC3300"></asp:Label>
                <br />
                <asp:Label ID="idPlanLabel" runat="server" Text="ID Plan"></asp:Label>
                <asp:TextBox ID="idPlanTextBox" runat="server"></asp:TextBox>
                <asp:Label ID="idPlanValidacion" runat="server" Text="*" ForeColor="#CC3300"></asp:Label>
                <br />

                <br />

                
                <asp:Label ID="validacionDescripcionCartel" runat="server" Text="* La descripcion no puede estar vacia" ForeColor="#CC3300"></asp:Label> 
                <br />
                <asp:Label ID="validacionAnioEspecialidadCartel" runat="server" Text="* El Anio Especialidad no puede estar vacio" ForeColor="#CC3300"></asp:Label>
                <br />
                <asp:Label ID="validacionIdPlanCartel" runat="server" Text="* Debe seleccionar un ID Plan" ForeColor="#CC3300"></asp:Label>
                <br />
                <br />
              

                     <asp:Panel ID="formActionsPanel" runat="server">
                        <asp:Button ID="aceptarLinkButton" runat="server" Text="Aceptar" OnClick="aceptarLinkButton_Click" />
                        <asp:Button ID="cancelarLinkButton" runat="server" Text="Cancelar" OnClick="cancelarLinkButton_Click" />
              

                    </asp:Panel>
            </asp:Panel>

            <asp:Panel ID="gridActionsPanel" runat="server">
                <asp:Button ID="editarLinkButton" runat="server" Text="Editar" OnClick="editarLinkButton_Click" Visible ="false" />
                <asp:Button ID="eliminarLinkButton" runat="server" Text="Eliminar" OnClick="eliminarLinkButton_Click"  Visible ="false" />
                <asp:Button ID="nuevoLinkButton" runat="server" Text="Nuevo" OnClick="nuevoLinkButton_Click"  Visible ="false" />

            </asp:Panel>
        </div>

     </asp:Content>   