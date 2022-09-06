<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientesForm.aspx.cs" Inherits="Practica_Etapa_Uno.aspx.ClientesForm" %>

<!DOCTYPE html>
<%-- PRACTICA 3: LABELS. TEXTBOXES. BUTTONES. 
        PRIMER BLOKE: AGREGAR CONTROLES PARA RECIBIR INFORMACION DEL CLIENTE NOMBRE COMPLETO SEPARADO POR APELLIDOS Y NOMBRE. IGUAL SE DEBE CAPTURAR LA FECHA DE NACIMIENTO.
        SEGUNDO BLOKE: AGREGAR BOTTON PARA GUARDAR.

        RECORDATORIO: Nomenclatura del ID debe de ser abreviacion del control mas la descripcion.
                      ID del Contol de BUTTON GUARDAR: btn + Guardar = "btnGuardar""

    ¡EXITO! EQUIPO......

 --%>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>CLIENTES</title>
</head>
<body style="padding-left:20%">
    <form id="form1" runat="server">
    <h3>CLIENTES:</h3>
         <div class="lbls-txts">
             <h5>Favor de capturar el nombre del Cliente</h5><br />
             <%-- PRIMER BLOKE --%> <%-- LABELS Y TEXBOXS --%>

             <%-- NOMBRE --%>
             <%--<asp:label ID="lblNombre" runat="server"> * Nombre: </asp:label>--%>

             <%-- APPELLIDO PATERNO --%>


             <%-- APPELLIDO MATERNO --%>


             <%-- FECHA DE NACIMIENTO --%>

         </div>
        
         <div class="btns">
            <%-- SEGUNDO BLOKE --%> <%-- BUTTONS AQUI--%>

             <%-- BOTON PARA GUARDAR--%>
            
         </div>
     </form>
</body>
</html>
