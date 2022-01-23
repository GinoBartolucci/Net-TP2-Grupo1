<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="UI.Web.Cursos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <h2>Cursos</h2>
    <hr />


    <div class="form-label-input">
        <label class="form" style="width: 100%">
            ID:
               <asp:TextBox CssClass="form-input" placeholder="ingresar ID del curso" ID="ingresoTextBox" runat="server"></asp:TextBox>

        </label>
        <asp:Button class="btn btn-primary" ID="buscarButton" runat="server" Text="Buscar" OnClick="buscarButton_Click" />
    </div>


    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White"
            Width="100%"
            DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged">

            <SelectedRowStyle BackColor="Black" ForeColor="White" />

            <Columns>
                <asp:BoundField HeaderText="ID" DataField="ID" />

                <asp:BoundField HeaderText="ID Materia" DataField="id_materia" />
                <asp:BoundField HeaderText="ID Comision" DataField="id_comision" />
                <asp:BoundField HeaderText="Año Calendario" DataField="anio_calendario" />
                <asp:BoundField HeaderText="Cupo" DataField="cupo" />
                <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />

            </Columns>
        </asp:GridView>
    </asp:Panel>


    <asp:Panel ID="formPanel" CssClass="p-3" runat="server" Visible="false">
        <h4>
            <asp:Label runat="server" ID="tituloForm" Text=""></asp:Label>
        </h4>
        <hr />
        <label>Cupo</label>
        <br />
        <asp:TextBox ID="cupoTextBox" CssClass="form-input" runat="server"></asp:TextBox>

        <div class="row py-3">
            <div class="col">
                <label>Año Calendario</label>
                <br />
                <asp:TextBox ID="anioCalendarioTextBox" CssClass="form-input" runat="server"></asp:TextBox>
            </div>
            <div class="col">
                <label>Id Materia</label>
                <br />
                <asp:TextBox ID="idMateriaTextBox" CssClass="form-input" runat="server" Enabled="false"></asp:TextBox>
                <asp:Button cssClass="btn btn-primary" runat="server" text="Seleccionar" OnClick="seleccionarMateriaButton" />
            </div>
            <div class="col">
                <label>Id Comision</label>
                <br />
                <asp:TextBox ID="idComisionTextBox" CssClass="form-input" runat="server" Enabled="false"></asp:TextBox>
                <asp:Button cssClass="btn btn-primary" runat="server" text="Seleccionar" OnClick="seleccionarComisionButton" />
            </div>

        </div>



        <br />
        <div class="row m-2 py-2" id="tablaMateria" runat="server" visible="false">
            <h3>Seleccionar materia</h3>
            <asp:Panel ID="materiaPanel" runat="server">
                <asp:GridView ID="materiaGridView" runat="server" AutoGenerateColumns="False"
                    SelectedRowStyle-BackColor="Black"
                    SelectedRowStyle-ForeColor="White"
                    Width="100%"
                    DataKeyNames="ID" OnSelectedIndexChanged="materiaGridView_SelectedIndexChanged">

                    <selectedrowstyle backcolor="Black" forecolor="White" />

                    <columns>
                        <asp:BoundField HeaderText="ID" DataField="ID" />

                        <asp:BoundField HeaderText="Descripcion materia" DataField="DescMateria" />
                        <asp:BoundField HeaderText="Horas Samanales" DataField="HorasSemanales" />
                        <asp:BoundField HeaderText="Horas Totales" DataField="HorasTotales" />
                        <asp:BoundField HeaderText="Id Plan" DataField="IdPlan" />
                        <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />

                    </columns>
                </asp:GridView>
            </asp:Panel>


        </div>
        <div id="tablaComision" runat="server" class="row m-2 py-2" visible="false">
            <h3>Seleccionar comision</h3>
            <asp:Panel ID="comisionPanel" CssClass="py-3" runat="server" Visible="false">
                <asp:GridView ID="comisionGridView" runat="server" AutoGenerateColumns="False"
                    SelectedRowStyle-BackColor="Black"
                    SelectedRowStyle-ForeColor="White"
                    Width="100%"
                    DataKeynames="ID">

                    <selectedrowstyle backcolor="Black" forecolor="White" />

                    <columns>
                        <asp:BoundField HeaderText="ID" DataField="ID" />
                        <asp:BoundField HeaderText="Descripcion" DataField="DescComision" />
                        <asp:BoundField HeaderText="Anio Especialidad" DataField="AnioEspecialidad" />
                        <asp:BoundField HeaderText="ID Plan" DataField="IdPlan" />
                        <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
                    </columns>

                </asp:GridView>
            </asp:Panel>
            <br />
        </div>
        <asp:Label ID="descripcionEspecialidadValidacion" runat="server" ForeColor="#CC3300" Text="*"></asp:Label>
        <br />
        <br />
        <asp:Panel ID="formActionsPanel" runat="server">
            <asp:Button ID="aceptarLinkButton" runat="server" class="btn btn-success" OnClick="aceptarLinkButton_Click" Text="Aceptar" />
            <asp:Button ID="cancelarLinkButton" runat="server" class="btn btn-danger" OnClick="cancelarLinkButton_Click" Text="Cancelar" />
        </asp:Panel>
    </asp:Panel>

    <asp:Panel CssClass="py-3" ID="gridActionsPanel" runat="server">
        <asp:Button ID="editarLinkButton" class="btn btn-dark" runat="server" Text="Editar" OnClick="editarLinkButton_Click" />
        <asp:Button ID="eliminarLinkButton" class="btn btn-danger" runat="server" Text="Eliminar" OnClick="eliminarLinkButton_Click" />
        <asp:Button ID="nuevoLinkButton" class="btn btn-success" runat="server" Text="Nuevo" OnClick="nuevoLinkButton_Click" />

    </asp:Panel>


</asp:Content>
