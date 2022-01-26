﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Materias.aspx.cs" Inherits="UI.Web.Materias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

    <h2>Materias</h2>
    <hr />


    <div class="form-label-input">
            <label class="form" style="width:100%">
                ID:
               <asp:TextBox CssClass="form-input" placeholder="ingresar ID de la materia" ID="materiaIngresoTextBox" runat="server"></asp:TextBox>
         
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

                <asp:BoundField HeaderText="Descripcion materia" DataField="DescMateria" />
                <asp:BoundField HeaderText="Horas Samanales" DataField="HorasSemanales" />
                <asp:BoundField HeaderText="Horas Totales" DataField="HorasTotales" />
                <asp:BoundField HeaderText="Id Plan" DataField="IdPlan" />
                <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />

            </Columns>
        </asp:GridView>
    </asp:Panel>


    <asp:Panel ID="formPanel" CssClass="p-3" runat="server" Visible="false">
        <h4><asp:Label runat="server" ID="tituloForm" Text=""></asp:Label></h4>
        <hr />
        <asp:Label ID="descripcionEspecialidadLabel" runat="server" Text="Descripcion"></asp:Label>
        <br />
        <asp:TextBox ID="descripcionTextBox" CssClass="form-input" runat="server" Columns="60" Height="50px" MaxLength="50" Rows="2"></asp:TextBox>

        <div class="row py-3">
            <div class="col">
                <label>
                Horas Semanales</label>
                <br />
                <asp:TextBox ID="horasSemanalesTextBox" runat="server" CssClass="form-input"></asp:TextBox>
            </div>
            <div class="col">
                <label>
                Horas Totales</label>
                <br />
                <asp:TextBox ID="horasTotalesTextBox" runat="server" CssClass="form-input"></asp:TextBox>
            </div>
            <div class="col">
                <label>
                Id Plan</label>
                <br />
                <asp:TextBox ID="idPlanTextBox" runat="server" CssClass="form-input" Enabled="false"></asp:TextBox>
                <asp:Button ID="seleccionaBtn" runat="server" cssClass="btn btn-primary" OnClick="seleccionarButton" text="Seleccionar especialidad" />
            </div>
        </div>
        <br />
        <div id="tablaPlan" runat="server" class="row m-2 py-2" visible="false">
            <h3>Seleccionar plan</h3>
            <asp:GridView ID="planGridView" runat="server" AutoGenerateColumns="False" DataKeynames="ID" OnSelectedIndexChanged="planGridView_SelectedIndexChanged" SelectedRowStyle-BackColor="Black" SelectedRowStyle-ForeColor="White" Width="100%">
                <SelectedRowStyle BackColor="Black" ForeColor="White" />
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" />
                    <asp:BoundField DataField="DescPlan" HeaderText="Descripcion Plan" />
                    <asp:BoundField DataField="DescEspecialidad" HeaderText="Especialidad" />
                    <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
        <br />
        <asp:Label ID="mensajeDeValidacionDeCampo" runat="server" Visible="false" Text=" Hay campos que faltan completar" ForeColor="#CC3300"></asp:Label>
        <br />



        <br />


        <asp:Panel ID="formActionsPanel" runat="server">
            <asp:Button ID="aceptarLinkButton" class="btn btn-success" runat="server" Text="Aceptar" OnClick="aceptarLinkButton_Click" />
            <asp:Button ID="cancelarLinkButton" class="btn btn-danger" runat="server" Text="Cancelar" OnClick="cancelarLinkButton_Click" />


        </asp:Panel>
    </asp:Panel>

    <asp:Panel CssClass="py-3" ID="gridActionsPanel" runat="server">
        <asp:Button ID="editarLinkButton" class="btn btn-dark" runat="server" Text="Editar" OnClick="editarLinkButton_Click" />
        <asp:Button ID="eliminarLinkButton" class="btn btn-danger" runat="server" Text="Eliminar" OnClick="eliminarLinkButton_Click" />
        <asp:Button ID="nuevoLinkButton" class="btn btn-success" runat="server" Text="Nuevo" OnClick="nuevoLinkButton_Click" />

    </asp:Panel>


</asp:Content>
