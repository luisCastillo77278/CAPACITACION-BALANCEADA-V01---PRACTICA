using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            

            /* 2. Ahora applica el color Azul(Blue) al borde del label "NOMBRE" usando la propiedad "BorderColor" */


        }

        /*********** EL CODIGO DE ABAJO VA DENTRO DEL METODO DE GUARDAR *******************/

        /*  ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ya entre')", true); */


    }
}