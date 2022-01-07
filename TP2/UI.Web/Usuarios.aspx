<%@ Page Language="C#" Title=" " AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios"  MasterPageFile="~/Site.Master"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">


    <div>


            <asp:Panel ID ="gridPanel" runat ="server" > 
            <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="false"
                SelectedRowStyle-BackColor="Black"
                SelectedRowStyle-ForeColor="White"
                DataKeynames ="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" >
 
                <SelectedRowStyle BackColor="Black" ForeColor="White" />
                
                <Columns>
                    <asp:BoundField HeaderText ="Nombre" DataField ="Nombre" />
                    <asp:BoundField HeaderText ="Apellido" DataField ="Apellido" />
                    <asp:BoundField HeaderText ="Email" DataField ="Email" />
                    <asp:BoundField HeaderText ="Usuario" DataField ="NombreUsuario" />
                    <asp:BoundField HeaderText ="Habilitado" DataField ="Habilitado" />
                    <asp:CommandField HeaderText ="Seleccionar" ShowSelectButton ="True" />

                </Columns>
            </asp:GridView>
            </asp:Panel>


            <asp:Panel ID="formPanel" runat="server" Visible ="false">
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

                
                <asp:Label ID="validacionNombreCartel" runat="server" Text="* El nombre no puede estar vacio" ForeColor="#CC3300"></asp:Label> 
                <br />
                <asp:Label ID="validacionApellidoCartel" runat="server" Text="* El apellido no puede estar vacio" ForeColor="#CC3300"></asp:Label>
                <br />
                <asp:Label ID="validacionEmailCartel" runat="server" Text="* El email es invalido" ForeColor="#CC3300"></asp:Label>
                <br />
                <asp:Label ID="validacionNombreUsuarioCartel" runat="server" Text="* El nombre usuario  no puede estar vacio" ForeColor="#CC3300"></asp:Label>
                <br />
                 <asp:Label ID="validacionClaveCartel" runat="server" Text="* Las claves no coinciden" ForeColor="#CC3300"></asp:Label>
              

                     <asp:Panel ID="formActionsPanel" runat="server">
                        <asp:Button ID="aceptarLinkButton" runat="server" Text="Aceptar" OnClick="aceptarLinkButton_Click" />
                        <asp:Button ID="cancelarLinkButton" runat="server" Text="Cancelar" OnClick="cancelarLinkButton_Click" />
              

                    </asp:Panel>
            </asp:Panel>

            <asp:Panel ID="gridActionsPanel" runat="server">
                <asp:Button ID="editarLinkButton" runat="server" Text="Editar" OnClick="editarLinkButton_Click" />
                <asp:Button ID="eliminarLinkButton" runat="server" Text="Eliminar" OnClick="eliminarLinkButton_Click" />
                <asp:Button ID="nuevoLinkButton" runat="server" Text="Nuevo" OnClick="nuevoLinkButton_Click" />

            </asp:Panel>
        </div>
 </asp:Content>   