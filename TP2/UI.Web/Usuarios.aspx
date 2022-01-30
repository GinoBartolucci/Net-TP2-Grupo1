<%@ Page Language="C#" Title=" " AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">


    <div class="container">
        <h2>Usuarios</h2>
        <hr />

        <div class="form-label-input">
            <label class="form" style="width: 100%">
                ID:
               <asp:TextBox CssClass="form-input" placeholder="ingresar ID de la comision"  type="number" min="0"  ID="idIngresoTextBox" runat="server"></asp:TextBox>

            </label>
            <asp:Button class="btn btn-primary" ID="buscarButton" runat="server" Text="Buscar" OnClick="buscarButton_Click" />
        </div>

        <asp:Panel CssClass="py-3" ID="gridPanel" runat="server">
            <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="false"
                SelectedRowStyle-BackColor="Black"
                SelectedRowStyle-ForeColor="White"
                Width="100%"
                DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged">

                <SelectedRowStyle BackColor="Black" ForeColor="White" />

                <Columns>
                    <asp:BoundField HeaderText="ID" DataField="id" />
                    <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                    <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                    <asp:BoundField HeaderText="Email" DataField="Email" />
                    <asp:BoundField HeaderText="Usuario" DataField="NombreUsuario" />
                    <asp:BoundField HeaderText="Habilitado" DataField="Habilitado" />
                    <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />

                </Columns>
            </asp:GridView>
        </asp:Panel>


        <asp:Panel CssClass="py-3" ID="formPanel" runat="server" Visible="false">
            <asp:Label ID="Label1" runat="server" Text="ID Persona"></asp:Label>
            <asp:TextBox ID="idPersonaTextBox" runat="server" Enabled="false"></asp:TextBox>
               <asp:Label ID="Label2" runat="server" Text="*" ForeColor="#CC3300"></asp:Label>
                <asp:Button runat="server" ID="idPersonaButton" Text="Seleccionar persona" CssClass="btn btn-primary" OnClick="idPersonaButton_Click" />


            <asp:Panel ID="personaPanel" Visible="false" runat="server" CssClass="tabla">
                <asp:GridView ID="AlumnosGridView" runat="server" AutoGenerateColumns="False"
                    SelectedRowStyle-BackColor="Black"
                    SelectedRowStyle-ForeColor="White"
                    Width="1000px"
                    DataKeyNames="ID" OnSelectedIndexChanged="AlumnosGridView_SelectedIndexChanged">

                    <SelectedRowStyle BackColor="Black" ForeColor="White" />

                    <Columns>
                        <asp:BoundField HeaderText="ID" DataField="ID" />

                        <asp:BoundField HeaderText="Legajo" DataField="Legajo" />
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                        <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                        <asp:BoundField HeaderText="Direccion" DataField="Direccion" />
                        <asp:BoundField HeaderText="Telefono" DataField="Telefono" />
                        <asp:BoundField HeaderText="Fecha de Nacimiento" DataField="Fecha_nac" />
                        <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />

                    </Columns>
                </asp:GridView>
            </asp:Panel>

             
                
            <div class="row">
                <div class="col">




                    <br />
                    <asp:Label ID="nombreLabel" runat="server" Text="Nombre"></asp:Label>
                    <asp:TextBox ID="nombreTextBox" AutoCompleteType="FirstName" runat="server"></asp:TextBox>
                    <asp:Label ID="nombreValidacion" runat="server" Text="*" ForeColor="#CC3300"></asp:Label>
                    <br />
                    <asp:Label ID="apellidoLabel" runat="server" Text="Apellido"></asp:Label>
                    <asp:TextBox ID="apellidoTextBox" AutoCompleteType="LastName" runat="server"></asp:TextBox>
                    <asp:Label ID="apellidoValidacion" runat="server" Text="*" ForeColor="#CC3300"></asp:Label>
                    <br />
                    <asp:Label ID="emailLabel" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox ID="emailTextBox" AutoCompleteType="Email" runat="server"></asp:TextBox>
                    <asp:Label ID="emailValidacion" runat="server" Text="*" ForeColor="#CC3300"></asp:Label>
                    <br />

                    <asp:Label ID="habilitadoLabel" runat="server" Text="Habilitado: "></asp:Label>
                    <asp:CheckBox ID="habilitadoCheckBox" runat="server" />
                    <br />


                    <asp:Label ID="nombreUsuarioLabel" runat="server" Text="Usuario: "></asp:Label>
                    <asp:TextBox ID="nombreUsuarioTextBox"    runat="server"></asp:TextBox>
                    <asp:Label ID="nombreUsuarioValidacion" runat="server" Text="*" ForeColor="#CC3300"></asp:Label>
                    <br />


                </div>
                <div class="col">
                    <asp:Label ID="Label3" runat="server" Text="Direccion"></asp:Label>
                    <asp:TextBox ID="direccionTextBox" AutoCompleteType="HomeStreetAddress" runat="server"></asp:TextBox>

                    <br />
                    <asp:Label ID="Label5" runat="server" Text="Telefono"></asp:Label>
                    <asp:TextBox type="number" ID="telefonoTextBox" AutoCompleteType="Cellular" runat="server"></asp:TextBox>

                    <br />
               

                    <asp:Label ID="Label9" runat="server" Text="Fecha de Nacimiento: "></asp:Label>
                    <asp:TextBox ID="fechaNacimientoTextBox" type="date" runat="server"></asp:TextBox>
                    <br />
                          <asp:Label ID="Label4" runat="server" Text="Tipo persona: "></asp:Label>
                    <asp:TextBox ID="tipoPersonaTextBox" type="number" min="1" max="3" runat="server"></asp:TextBox>
                    <br />
                </div>
            </div>


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
            <asp:Label ID="validacionClaveCartel" Visible="false" runat="server" Text="* Las claves no coinciden" ForeColor="#CC3300"></asp:Label>


            <asp:Panel ID="formActionsPanel" runat="server">
                <asp:Button CssClass="btn btn-success" ID="aceptarLinkButton" runat="server" Text="Aceptar" OnClick="aceptarLinkButton_Click" />
                <asp:Button CssClass="btn btn-danger" ID="cancelarLinkButton" runat="server" Text="Cancelar" OnClick="cancelarLinkButton_Click" />


            </asp:Panel>
        </asp:Panel>

        <asp:Panel ID="gridActionsPanel" runat="server">
            <asp:Button ID="editarLinkButton" CssClass="btn btn-dark" runat="server" Text="Editar" OnClick="editarLinkButton_Click" />
            <asp:Button ID="habilitarLinkButton" CssClass="btn btn-danger" runat="server" Text="Habilitar" OnClick="habilitarLinkButton_Click" />
            <asp:Button ID="nuevoLinkButton" CssClass="btn btn-success" runat="server" Text="Nuevo" OnClick="nuevoLinkButton_Click" />

        </asp:Panel>
    </div>
</asp:Content>
