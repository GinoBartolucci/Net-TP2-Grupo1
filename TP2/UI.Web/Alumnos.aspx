<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alumnos.aspx.cs" Inherits="UI.Web.Alumnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <h2>Alumnos</h2>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    
        <hr/>
    <br />
    <br />
 
              <asp:Panel ID ="gridPanel" runat ="server" CssClass="tabla" > 
            <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
                SelectedRowStyle-BackColor="Black"
                SelectedRowStyle-ForeColor="White"
            Width="800px"
                DataKeynames ="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" >
 
                <SelectedRowStyle BackColor="Black" ForeColor="White" />
                
                <Columns>
                    <asp:BoundField HeaderText ="ID" DataField ="ID" />
        
                    <asp:BoundField HeaderText ="IdAlumno" DataField ="IdAlumno" /> 
                    <asp:BoundField HeaderText ="Legajo" DataField ="Legajo" />
                    <asp:BoundField HeaderText ="NombreApellido" DataField ="NombreApellido" /> 
                    <asp:BoundField HeaderText ="IdCurso" DataField ="IdCurso" />  
                    <asp:BoundField HeaderText ="Condicion" DataField ="Nota" />  
                    <asp:BoundField HeaderText ="DescMateria" DataField ="DescMateria" />  
                    <asp:CommandField HeaderText ="Seleccionar" ShowSelectButton ="True" />

                </Columns>
            </asp:GridView>
            </asp:Panel>
           
    <br />

        <div class ="form-label-input">
            <label class="form" style="width:100%">
                Legajo:
               <asp:TextBox CssClass="form-input" placeholder="ingresar ID" ID="IdIngresoTextBox" runat="server"></asp:TextBox>
         
            </label>
            <asp:Button class="btn btn-primary" ID="buscarButton" runat="server" Text="Buscar" OnClick="buscarButton_Click" />
        </div>
    <asp:Button class="btn btn-primary" runat="server" Text="Agregar" />
    <asp:Button class="btn btn-primary" runat="server" Text="Ver cursos" />
    <asp:Button class="btn btn-primary" runat="server" Text="Ver nota" />
    <asp:Button class="btn btn-danger" runat="server" Text="Dar de baja" />

    
    <section class="modificar-alumno" id="modificar_alumno" runat="server">
      <form method="post" action="">
            
            <div class="form-col-2">
                <div class ="form-label-input" >
                    <label>ID: </label>
                    <asp:TextBox CssClass="form-input" placeholder="ID" ID="idTextBox" runat="server"></asp:TextBox>
                 </div>
                <div class ="form-label-input" >
                    <asp:TextBox CssClass="form-input" placeholder="ID Alumno" ID="idAlumnoTextBox" runat="server"></asp:TextBox>
                 </div>
            </div>

              <div class="form-col-2">
                <div class ="form-label-input" >
                    <label>Nombre y Apellido: </label>
                    <asp:TextBox CssClass="form-input" placeholder="Nombre y apellido" ID="nombreYapellidoTextBox" runat="server"></asp:TextBox>
                 </div>
                <div class ="form-label-input" >
                    <asp:TextBox CssClass="form-input" placeholder="Condicion" ID="condicionTextBox" runat="server"></asp:TextBox>
                 </div>
            </div>

                <div class="form-col-2">
                <div class ="form-label-input" >
                    <asp:TextBox CssClass="form-input" placeholder="ID Curso" ID="idCursoTextBox" runat="server"></asp:TextBox>
                 </div>
                <div class ="form-label-input" >
                    <asp:TextBox CssClass="form-input" placeholder="Desc Materia" ID="descMateriaTextBox" runat="server"></asp:TextBox>
                 </div>
            </div>

 
       <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Agregar" OnClick="agregarAlumnoButton_Click" />
    </form>
    </section>




    
</asp:Content>
