<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Iniciar Sesion</title>
    <style>
        #form1 {
            display: flex;
            justify-content: center;
            align-items: center;
            width: 100%;
            height: 100vh;
        }

        #cartelErrorLabel{
            color:red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="usuarioLabel" runat="server" Text="Ingresar Usuario: "></asp:Label>
            <br />
            <asp:TextBox ID="usuarioTextBox" runat="server"></asp:TextBox>
             <br />
            <asp:Label ID="contraseniaLabel" runat="server" Text="Ingresar contrasenia: "></asp:Label>
            <br />
            <asp:TextBox ID="contraseniaTextBox" runat="server" type ="password"></asp:TextBox>
            <br />
            <asp:Button ID="ingresarButton" runat="server" Text="Ingresar" OnClick="ingresarButton_Click" />
            <br />
            <br /> 
            <asp:Label ID="cartelErrorLabel" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
