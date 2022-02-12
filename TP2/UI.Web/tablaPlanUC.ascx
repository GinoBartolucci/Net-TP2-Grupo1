<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tablaPlanUC.ascx.cs" Inherits="UI.Web.tablaPlanUC" %>

          <asp:GridView ID="planGridView" runat="server" 
                    CssClass="table caption-top"
                    AutoGenerateColumns="False" DataKeyNames="ID" OnSelectedIndexChanged="planGridView_SelectedIndexChanged" SelectedRowStyle-BackColor="Black" SelectedRowStyle-ForeColor="White" Width="100%">
                    <SelectedRowStyle BackColor="Black" ForeColor="White" />
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" />
                        <asp:BoundField DataField="DescPlan" HeaderText="Descripcion Plan" />
                        <asp:BoundField DataField="DescEspecialidad" HeaderText="Especialidad" />
                        <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
                    </Columns>
         </asp:GridView>