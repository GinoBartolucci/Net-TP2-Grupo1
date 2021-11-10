<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Comisiones.aspx.cs" Inherits="UI.Web.Comisiones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        <div>


            <asp:Panel ID ="gridPanel" runat ="server" > 
            <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
                SelectedRowStyle-BackColor="Black"
                SelectedRowStyle-ForeColor="White"
                DataKeynames ="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" >
 
                <SelectedRowStyle BackColor="Black" ForeColor="White" />
                
                <Columns>
                    <asp:BoundField HeaderText ="Descripcion" DataField ="desc_comision" />
                    <asp:BoundField HeaderText ="Anio Especialidad" DataField ="anio_especialidad" />
                    <asp:BoundField HeaderText ="ID Plan" DataField ="id_plan" />
                    <asp:CommandField HeaderText ="Seleccionar" ShowSelectButton ="True" Visible ="false" />

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
    </form>
</body>
</html>
