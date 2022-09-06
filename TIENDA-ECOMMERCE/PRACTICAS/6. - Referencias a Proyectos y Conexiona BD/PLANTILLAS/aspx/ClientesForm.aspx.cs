using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using ProdeskNet.BD; //Descomentar cuando se tenga el Proyect ProdeskNet.BD

namespace Practica_Etapa_Uno.aspx
{
    public partial class ClientesForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* EJEMPLO DE COLOR DE FONDO (AQUA)  ---- LblNombre.BackColor = System.Drawing.Color.Aqua; ----SOLO DEBES DESCOMENTAR LINEA DE ABAJO Y EN EL FRONT PARA VER CAMBIOS SOBRE VISTA. */
            //lblNombre.BackColor = System.Drawing.Color.Aqua;
            /* RECUERDA el Control se llama con el attributo ID */

            /* 1. Primero se inicia el Label con la propiedad "BorderWidth" sobre label "NOMBRE".  **** (Applica la propiedad "BorderWidth" al label "NOMBRE" *** */
            lblNombre.BorderWidth = 1;

            /* 2. Ahora applica el color Azul(Blue) al borde del label "NOMBRE" usando la propiedad "BorderColor" */
            lblNombre.BorderColor = System.Drawing.Color.Blue;


        }

        /*********** EL CODIGO DE ABAJO VA DENTRO DEL METODO DE GUARDAR *******************/

        /*  ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ya entre')", true); */


        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //Descomentar cuando se tenga el Proyect ProdeskNet.BD
            //clsManejaBD DB = new clsManejaBD(); /*INSTANCIACION DE CLASE de conexion a Base De Datos.*/

            /*Seteamos en variables el valor recuperado*/
            /*Para recuperar dato de control se obtiene de la siguiente manera nombre del id del control mas ".Text si es TextBox"*/

            /*Recuerda recuperar los valores de nombre, Apellidos y Fecha de Nacimiento sobre valirables*/
            string Nombre = txtNombre.Text; /*EJEMPLO para obtener el valor de Nombre seria txtNombre.Text*/
            string ApPaterno = string.Empty;
            string ApMaterno = string.Empty;
            string FechaNacimiento = string.Empty;
            string strSQl = string.Empty;

            /*************** CON SEQUENCIA*********************/
            //string Nombre_Sequencia = "SQ_ID_CLIENTES"; /*Nombre de sequencia va en el valor de "Nombre_Sequencia"*/

            //strSQl = " INSERT INTO CLIENTES " +
            //         " Select NEXT VALUE FOR [dbo].[" + Nombre_Sequencia + "]" +
            //         ",'" + Nombre +
            //         "', '" + ApPaterno +
            //         "', '" + ApMaterno +
            //         "', '" + FechaNacimiento + "';";


            /****************SIN SEQUENCIA******************************/
            //string Nombre_Sequencia = "SQ_ID_CLIENTES"; /*Nombre de sequencia va en el valor de "Nombre_Sequencia"*/
            //strSQl = " INSERT INTO CLIENTES " +
            //" Select " +
            //",'" + Nombre +
            //"', '" + ApPaterno +
            //"', '" + ApMaterno +
            //"', '" + FechaNacimiento + "';";


            /**************Cuando ya estes connectado al Proyecto de BD descomentarlo.**************************/
            //DB.ExInsUpd(strSQl);



            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Registro Guardado exitosamente.')", true);
        }


    }
}