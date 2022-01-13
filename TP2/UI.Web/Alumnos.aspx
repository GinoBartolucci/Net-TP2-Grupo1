<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alumnos.aspx.cs" Inherits="UI.Web.Alumnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <h2>Alumnos</h2>
    <hr/>
         

    <asp:Button class="mdc-button mdc-button--raised" runat="server" Text="Agregar" />
    <asp:Button class="mdc-button mdc-button--raised" runat="server" Text="Dar de baja" />


    <section class="crear-alumno" id="seccion_crear_alumno" runat="server">
      <form method="post" action="">
        <div class ="form-label-input">
            <label class="mdc-text-field mdc-text-field--filled" style="width:100%">
              <span class="mdc-text-field__ripple"><p style="font-size:14px; color:gray; padding-left:4px;">Legajo</p></span>
              <span class="mdc-floating-label" id="my-label-id">   </span>
               <asp:TextBox CssClass="mdc-text-field__input" ID="legajoTextBox" runat="server"></asp:TextBox>
              <span class="mdc-line-ripple"></span>
            </label>
        </div>
        
     <div class="form-col-2">


        <div class ="form-label-input" >
           
            <label class="mdc-text-field mdc-text-field--filled" style="width:100%">
            <span class="mdc-text-field__ripple"><p style="font-size:14px; color:gray; padding-left:4px;">Nombre</p></span>
              <span class="mdc-floating-label" id="my-label-id">   </span>
               <asp:TextBox CssClass="mdc-text-field__input" ID="nombreTextBox" runat="server"></asp:TextBox>
              <span class="mdc-line-ripple"></span>
            </label>
        </div>

        <div class ="form-label-input" >
           
            <label class="mdc-text-field mdc-text-field--filled" style="width:100%">
                <span class="mdc-text-field__ripple"><p style="font-size:14px; color:gray; padding-left:4px;">Apellido</p></span>
              <span class="mdc-floating-label" id="my-label-id">   </span>
               <asp:TextBox CssClass="mdc-text-field__input" ID="apellidoTextBox" runat="server"></asp:TextBox>
              <span class="mdc-line-ripple"></span>
            </label>
        </div>
           </div>

          <div class="form-col-2">
        <div class ="form-label-input" >
            <label class="mdc-text-field mdc-text-field--filled"  style="width:100%">
               <span class="mdc-text-field__ripple"><p style="font-size:14px; color:gray; padding-left:4px;">Fecha de Nacimiento (yyyy-mm-dd)</p></span>
              <span class="mdc-floating-label" id="my-label-id"> </span>
            
               <asp:TextBox CssClass="mdc-text-field__input" ID="fechaNacimientoTextBox" runat="server"></asp:TextBox>
              <span class="mdc-line-ripple"> </span>
            </label>
        </div>
           
        <div class ="form-label-input" >
          
            <label class="mdc-text-field mdc-text-field--filled" style="width:100%">
              <span class="mdc-text-field__ripple"><p style="font-size:14px; color:gray; padding-left:4px;">Dirección</p></span>
              <span class="mdc-floating-label" id="my-label-id">   </span>
               <asp:TextBox CssClass="mdc-text-field__input" ID="direccionTextBox" runat="server"></asp:TextBox>
              <span class="mdc-line-ripple"></span>
            </label>
        </div>
              </div>

        <div class="form-col-2">
          </div>
          <div class ="form-label-input" >
       
            <label class="mdc-text-field mdc-text-field--filled" style="width:100%">
              <span class="mdc-text-field__ripple"><p style="font-size:14px; color:gray; padding-left:4px;">Email</p></span>
              <span class="mdc-floating-label" id="my-label-id">   </span>
               <asp:TextBox CssClass="mdc-text-field__input" ID="emailTextBox" runat="server"></asp:TextBox>
              <span class="mdc-line-ripple"></span>
            </label>
        </div>

        
          <div class ="form-label-input" >
      
            <label class="mdc-text-field mdc-text-field--filled" style="width:100%">
             <span class="mdc-text-field__ripple"><p style="font-size:14px; color:gray; padding-left:4px;">Telefono</p></span>
              <span class="mdc-floating-label" id="my-label-id">   </span>
               <asp:TextBox CssClass="mdc-text-field__input" ID="telefonoTextBox" runat="server"></asp:TextBox>
              <span class="mdc-line-ripple"></span>
            </label>
        </div>
   

 
       <asp:Button ID="agregarAlumnoButton" class="mdc-button mdc-button--raised" runat="server" Text="Agregar" OnClick="agregarAlumnoButton_Click" />
    </form>
    </section>




    
</asp:Content>
