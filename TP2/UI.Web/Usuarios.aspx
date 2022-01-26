<%@ Page Language="C#" Title=" " AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios"  MasterPageFile="~/Site.Master"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">


    <div class="container">
          <h2>Usuarios</h2>  
        <hr/>

        <div class ="form-label-input">
            <label class="form" style="width:100%">
                ID:
               <asp:TextBox CssClass="form-input" placeholder="ingresar ID de la comision" ID="idIngresoTextBox" runat="server"></asp:TextBox>
         
            </label>
            <asp:Button class="btn btn-primary" ID="buscarButton" runat="server" Text="Buscar" OnClick="buscarButton_Click" />
        </div>

            <asp:Panel cssClass="py-3" ID ="gridPanel" runat ="server" > 
            <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="false"
                SelectedRowStyle-BackColor="Black"
                SelectedRowStyle-ForeColor="White"
                Width="100%"
                DataKeynames ="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" >
 
                <SelectedRowStyle BackColor="Black" ForeColor="White" />
                
                <Columns>
                    <asp:BoundField HeaderText ="ID" DataField ="id" />
                    <asp:BoundField HeaderText ="Nombre" DataField ="Nombre" />
                    <asp:BoundField HeaderText ="Apellido" DataField ="Apellido" />
                    <asp:BoundField HeaderText ="Email" DataField ="Email" />
                    <asp:BoundField HeaderText ="Usuario" DataField ="NombreUsuario" />
                    <asp:BoundField HeaderText ="Habilitado" DataField ="Habilitado" />
                    <asp:CommandField HeaderText ="Seleccionar" ShowSelectButton ="True" />

                </Columns>
            </asp:GridView>
            </asp:Panel>


            <asp:Panel cssClass="py-3" ID="formPanel" runat="server" Visible ="false">
                   <asp:Label ID="Label1" runat="server" Text="ID Persona"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Enabled="false"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="*" ForeColor="#CC3300"></asp:Label>
                <asp:Button runat="server" ID="idPersonaButton" Text="Seleccionar persona" CssClass="btn btn-primary"/>
                <br />
                <asp:Label ID="nombreLabel" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="nombreTextBox" runat="server"></asp:TextBox>
                <asp:Label ID="nombreValidacion" runat="server" Text="*" ForeColor="#CC3300"></asp:Label>
                <br />
                <asp:Label ID="apellidoLabel" runat="server" Text="Apellido"></asp:Label>
                <asp:TextBox ID="apellidoTextBox" runat="server"></asp:TextBox>
                <asp:Label ID="apellidoValidacion" runat="server" Text="*" ForeColor="#CC3300"></asp:Label>
                <br />
                <asp:Label ID="emailLabel" runat="server" Text="Email"></asp:Label>
                <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
                <asp:Label ID="emailValidacion" runat="server" Text="*" ForeColor="#CC3300"></asp:Label>
                <br />

                  <asp:Label ID="habilitadoLabel" runat="server" Text="Habilitado: "></asp:Label>
                  <asp:CheckBox ID="habilitadoCheckBox" runat="server" />
                <br />


                  <asp:Label ID="nombreUsuarioLabel" runat="server" Text="Usuario: "></asp:Label>
                <asp:TextBox ID="nombreUsuarioTextBox" runat="server"></asp:TextBox>
                <asp:Label ID="nombreUsuarioValidacion" runat="server" Text="*" ForeColor="#CC3300"></asp:Label>
                <br />

                  <asp:Label ID="claveLabel" runat="server" Text="Clave"></asp:Label>
                <asp:TextBox ID="ClaveTextBox" runat="server" TextMode="Password"></asp:TextBox>
                <asp:Label ID="claveValidacion" runat="server" Text="*" ForeColor="#CC3300"></asp:Label>
                <br />

                
                  <asp:Label ID="repetirClaveLabel" runat="server" Text="Repetir Clave"></asp:Label>
                <asp:TextBox ID="repetirClaveTextBox" runat="server" TextMode="Password"></asp:TextBox>
                <asp:Label ID="RepetirClaveValidacion" runat="server" Text="*" ForeColor="#CC3300"></asp:Label>
                <br />

                
                <asp:Label ID="validacionNombreCartel" Visible="false" runat="server" Text="* El nombre no puede estar vacio" ForeColor="#CC3300"></asp:Label> 
                <br />
                <asp:Label ID="validacionApellidoCartel" Visible="false" runat="server" Text="* El apellido no puede estar vacio" ForeColor="#CC3300"></asp:Label>
                <br />
                <asp:Label ID="validacionEmailCartel" Visible="false" runat="server" Text="* El email es invalido" ForeColor="#CC3300"></asp:Label>
                <br />
                <asp:Label ID="validacionNombreUsuarioCartel" Visible="false" runat="server" Text="* El nombre usuario  no puede estar vacio" ForeColor="#CC3300"></asp:Label>
                <br />
                 <asp:Label ID="validacionClaveCartel"  Visible="false" runat="server" Text="* Las claves no coinciden" ForeColor="#CC3300"></asp:Label>
              

                     <asp:Panel ID="formActionsPanel" runat="server">
                        <asp:Button cssClass="btn btn-success" ID="aceptarLinkButton" runat="server" Text="Aceptar" OnClick="aceptarLinkButton_Click" />
                        <asp:Button cssClass="btn btn-danger" ID="cancelarLinkButton" runat="server" Text="Cancelar" OnClick="cancelarLinkButton_Click" />
              

                    </asp:Panel>
            </asp:Panel>

            <asp:Panel ID="gridActionsPanel" runat="server">
                <asp:Button ID="editarLinkButton" cssClass="btn btn-dark" runat="server" Text="Editar" OnClick="editarLinkButton_Click" />
                <asp:Button ID="habilitarLinkButton" cssClass="btn btn-danger" runat="server" Text="Habilitar" OnClick="habilitarLinkButton_Click" />
                <asp:Button ID="nuevoLinkButton" cssClass="btn btn-success" runat="server" Text="Nuevo" OnClick="nuevoLinkButton_Click" />

            </asp:Panel>
        </div>
 </asp:Content>   