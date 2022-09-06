  protected void btnGuardar_Click(object sender, EventArgs e)
        {
            bllCliente Cliente = new bllCliente(); /*INSTANCIACION DE CLASE de conexion a Base De Datos.*/

            Cliente.Nombre = txtNombre.Text; /*EJEMPLO para obtener el valor de Nombre seria txtNombre.Text*/
            Cliente.ApPaterno = txtAPaterno.Text;
            Cliente.ApMaterno = txtAMaterno.Text;
            Cliente.FechaNacimiento = txtFech_Nac.Text;

            Cliente.ManejaCliente(1);


            
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Registro Guardado exitosamente.')", true); 
        }