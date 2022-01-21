<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alumnos.aspx.cs" Inherits="UI.Web.Alumnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
  
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <h2>Alumnos</h2>  
        <hr/>
    <br />
        <asp:Button ID="agregarAlumnoButton" class="btn btn-success" runat="server" Text="Agregar nuevo alumno" OnClick="agregarAlumnoButton_Click" />
               <br />    
        <div class ="form-label-input">
            <label class="form" style="width:100%">
                ID:
               <asp:TextBox CssClass="form-input" placeholder="ingresar ID del alumno" ID="idAlumnoIngresoTextBox" runat="server"></asp:TextBox>
         
            </label>
            <asp:Button class="btn btn-primary" ID="buscarButton" runat="server" Text="Buscar" OnClick="buscarButton_Click" />
        </div>
    
        <br />  
                   <asp:Panel ID ="alumnosPanel" runat ="server" CssClass="tabla" > 
            <asp:GridView ID="AlumnosGridView" runat="server" AutoGenerateColumns="False"
                SelectedRowStyle-BackColor="Black"
                SelectedRowStyle-ForeColor="White"
                 Width="1000px"
                DataKeynames ="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" >
 
                <SelectedRowStyle BackColor="Black" ForeColor="White" />
                
                <Columns>
                    <asp:BoundField HeaderText ="ID" DataField ="ID" />
        
                    <asp:BoundField HeaderText ="Legajo" DataField ="Legajo" />  
                    <asp:BoundField HeaderText ="Nombre" DataField ="Nombre" /> 
                    <asp:BoundField HeaderText ="Apellido" DataField ="Apellido" /> 
                    <asp:BoundField HeaderText ="Direccion" DataField ="Email" />  
                    <asp:BoundField HeaderText ="Telefono" DataField ="Telefono" />  
                    <asp:BoundField HeaderText ="Fecha de Nacimiento" DataField ="Fecha_nac" />  
                    <asp:CommandField HeaderText ="Seleccionar" ShowSelectButton ="True" />

                </Columns>
            </asp:GridView>
            </asp:Panel>
 
    <br />

        
    <asp:Button class="btn btn-info" ID="cursosAlumnoButton" runat="server" Text="Ver cursos" OnClick="cursosAlumnoButton_Click" />
        <asp:Button class="btn btn-info" ID="inscripcionesAlumnoButton" runat="server" Text="Ver inscripciones" OnClick="inscripcionesAlumnoButton_Click" />
    <asp:Button class="btn btn-dark"  ID="modificarAlumnoButton" runat="server" Text="Modificar" OnClick="modificarAlumnoButton_Click1" />

    <section id="cursos_alumno" runat="server" Visible="false">
        <asp:Panel ID="cursoPanel" runat="server">
        <asp:GridView ID="cursoGridView" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White"
            Width="100%"
            DataKeyNames="ID">

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
    </section>

    <section class="inscripciones_alumno" id="inscripciones_alumno" runat="server">
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
        <asp:Button class="btn btn-primary"  ID="asignarInscripcionButton" runat="server" Text="Asignarle inscripcion" Visible="false" OnClick="asignarInscripcionButton_Click" />
        <asp:Button class="btn btn-warning"  ID="asignarNotaInscripcionButton" runat="server" Text="Asignar nota" />
         <asp:Button class="btn btn-danger"  ID="darDeBajaInscripcionButton" runat="server" Text="Dar de baja" />
   
    </section>
    

    <section class="container modificar-alumno" id="form_alumno" runat="server">
      
        <h4><asp:Label runat="server" ID="tituloForm" Text=""></asp:Label></h4>
        <hr/>
        <form method="post" action="">
            
            <div class="form-col-2">
                <div class ="form-label-input" >
                    <label>Legajo: </label>
                    <asp:TextBox CssClass="form-input" placeholder="Legajo" ID="legajoTextBox" runat="server"></asp:TextBox>
                 </div>
                <div class ="form-label-input" >
                    <asp:TextBox CssClass="form-input" placeholder="Nombre" ID="nombreAlumnoTextBox" runat="server"></asp:TextBox>
                 </div>
            </div>

              <div class="form-col-2">
                <div class ="form-label-input" >
                    <label>Apellido: </label>
                    <asp:TextBox CssClass="form-input" placeholder="Apellido" ID="apellidoAlumnoTextBox" runat="server"></asp:TextBox>
                 </div>
                <div class ="form-label-input" >
                    <asp:TextBox CssClass="form-input" placeholder="Direccion" ID="direccionAlumnoTextBox" runat="server"></asp:TextBox>
                 </div>
            </div>

                <div class="form-col-2">
                <div class ="form-label-input" >
                    <asp:TextBox CssClass="form-input" placeholder="Telefono" ID="telefonoTextBox" runat="server"></asp:TextBox>
                 </div>
                <div class ="form-label-input" >
                    <asp:TextBox CssClass="form-input" placeholder="Fecha de Nacimiento (yyyy-mm-dd)" ID="fechaNacimientoTextBox" runat="server"></asp:TextBox>
                 </div>
            </div>
            <div class="form-col-2">
                <div class ="form-label-input" >
                    <asp:TextBox CssClass="form-input" placeholder="Email" ID="emailAlumnoTextBox" runat="server"></asp:TextBox>
                 </div>
                <div class ="form-label-input" >
                    <asp:TextBox CssClass="form-input" placeholder="Id Plan" ID="idPlanTextBox" runat="server"></asp:TextBox>
                 </div>
       
            </div>
            <asp:Button ID="formAlumnoButton" class="btn btn-success" runat="server" Text="Guardar" OnClick="formAlumnoButton_Click" />
            <asp:Button ID="cancelarFormAlumnoButton" class="btn btn-danger" runat="server" Text="Cancelar" OnClick="cancelarFormAlumnoButton_Click" />
    </form>
    </section>




     <div runat="server" id="div_mensaje_error">
            <svg xmlns="http://www.w3.org/2000/svg" style="display: none;">
          <symbol id="check-circle-fill" fill="currentColor" viewBox="0 0 16 16">
            <path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-3.97-3.03a.75.75 0 0 0-1.08.022L7.477 9.417 5.384 7.323a.75.75 0 0 0-1.06 1.06L6.97 11.03a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 0 0-.01-1.05z"/>
          </symbol>
          <symbol id="info-fill" fill="currentColor" viewBox="0 0 16 16">
            <path d="M8 16A8 8 0 1 0 8 0a8 8 0 0 0 0 16zm.93-9.412-1 4.705c-.07.34.029.533.304.533.194 0 .487-.07.686-.246l-.088.416c-.287.346-.92.598-1.465.598-.703 0-1.002-.422-.808-1.319l.738-3.468c.064-.293.006-.399-.287-.47l-.451-.081.082-.381 2.29-.287zM8 5.5a1 1 0 1 1 0-2 1 1 0 0 1 0 2z"/>
          </symbol>
          <symbol id="exclamation-triangle-fill" fill="currentColor" viewBox="0 0 16 16">
            <path d="M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"/>
          </symbol>
        </svg>

 
        <div class="alert alert-warning d-flex align-items-center" role="alert">
          <svg class="bi flex-shrink-0 me-2" width="24" height="24" role="img" aria-label="Warning:"><use xlink:href="#exclamation-triangle-fill"/></svg>
          <div>
             <asp:Label ID="mensaje_error" runat="server" Text="Error"></asp:Label>
          </div>
</div>
            </div>
</asp:Content>
