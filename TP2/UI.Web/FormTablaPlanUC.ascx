<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FormTablaPlanUC.ascx.cs" Inherits="UI.Web.FormTablaPlanUC" %>
<%@ Register Src="~/tablaPlanUC.ascx" TagPrefix="uc1" TagName="tablaPlanUC" %>


<div id="tablaPlan" runat="server" class="row m-2 py-2">
                <h3>Seleccionar plan</h3>
                <uc1:tablaPlanUC runat="server" id="tablaPlanUC" />
     
            </div>