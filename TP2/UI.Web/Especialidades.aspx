<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="UI.Web.Especialidades" %>

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
                    <asp:BoundField HeaderText ="ID" DataField ="ID" />
        
                    <asp:BoundField HeaderText ="Descripcion" DataField ="desc_especialidad" />  
                    <asp:CommandField HeaderText ="Seleccionar" ShowSelectButton ="True" />

                </Columns>
            </asp:GridView>
            </asp:Panel>


            <asp:Panel ID="formPanel" runat="server" Visible ="false">
                <asp:Label ID="descripcionEspecialidadLabel" runat="server" Text="Descripcion"></asp:Label>
                      <br />
                <asp:TextBox ID ="descripcionTextBox" runat="server" Columns="60" Height="50px" MaxLength="50" Rows="2"></asp:TextBox>
                
                <asp:Label ID="descripcionEspecialidadValidacion" runat="server" Text="*" ForeColor="#CC3300"></asp:Label>
                <br />
                <br />
                <br />

                
                  <br />
                <asp:Label ID="validacionDescripcionEspecialidad" runat="server" Text="* La descripcion no puede estar vacia" ForeColor="#CC3300"></asp:Label>
                <br />

                
                <br />
                <br />
                <br />
              

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
    </form>

</body>
</html>
