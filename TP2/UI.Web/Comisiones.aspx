<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Comisiones.aspx.cs"  MasterPageFile="~/Site.Master" Inherits="UI.Web.Comisiones" %>

 <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

    <div class="container"> 
          <h2>Comisiones</h2>  
        <hr/>
    
          <div class ="form-label-input">
            <label class="form" style="width:100%">
                ID:
               <asp:TextBox CssClass="form-input" placeholder="ingresar ID de la comision" ID="especialidadIngresoTextBox" runat="server"></asp:TextBox>
         
            </label>
            <asp:Button class="btn btn-primary" ID="buscarButton" runat="server" Text="Buscar" />
        </div>

            <asp:Panel ID ="gridPanel" CssClass="py-3" runat ="server"  Visible ="false"> 
            <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
                SelectedRowStyle-BackColor="Black"
                SelectedRowStyle-ForeColor="White" 
                Width="100%"
                DataKeynames ="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" 
               >
 
                <SelectedRowStyle BackColor="Black" ForeColor="White" />
                
                <Columns>
                    <asp:BoundField HeaderText="ID" DataField="id" />
                    <asp:BoundField  HeaderText ="Descripcion" DataField ="DescComision" />
                    <asp:BoundField HeaderText ="Anio Especialidad" DataField ="AnioEspecialidad" />
                    <asp:BoundField HeaderText ="ID Plan" DataField ="IdPlan" />
                    <asp:CommandField HeaderText ="Seleccionar" ShowSelectButton ="True"/>

                </Columns>

            </asp:GridView>
              </asp:Panel>

            <asp:Panel CssClass="py-3" id="panelAlumnosDocentes" runat="server"> 
                <asp:GridView ID="gridViewDocenteAlumno" runat="server" AutoGenerateColumns="False"  
                   DataKeynames ="ID" >
 
                <SelectedRowStyle BackColor="Black" ForeColor="White" />
                
                <Columns>
                    <asp:BoundField HeaderText="ID" DataField="id" />
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
                        <asp:Button ID="aceptarLinkButton" CssClass="btn btn-success" runat="server" Text="Aceptar" OnClick="aceptarLinkButton_Click" />
                        <asp:Button ID="cancelarLinkButton" CssClass="btn btn-danger" runat="server" Text="Cancelar" OnClick="cancelarLinkButton_Click" />
              

                    </asp:Panel>
            </asp:Panel>

            <asp:Panel ID="gridActionsPanel" runat="server">
                <asp:Button ID="editarLinkButton" CssClass="btn btn-dark" runat="server" Text="Editar" OnClick="editarLinkButton_Click" Visible ="false" />
                <asp:Button ID="eliminarLinkButton" CssClass="btn btn-danger" runat="server" Text="Eliminar" OnClick="eliminarLinkButton_Click"  Visible ="false" />
                <asp:Button ID="nuevoLinkButton" CssClass="btn btn-success" runat="server" Text="Nuevo" OnClick="nuevoLinkButton_Click"  Visible ="false" />

            </asp:Panel>
        </div>

     </asp:Content>   