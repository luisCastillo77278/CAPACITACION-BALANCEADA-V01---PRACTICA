using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProdeskNet.BD;

namespace Practica.BLL
{
    public class bllCliente
    {


        clsManejaBD bd = new clsManejaBD();

        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string FechaNacimiento { get; set; }

        public void ManejaCliente(int opc)
        {
            //0 Consultar
            //1 Insertar
            //2 Actualizar
            //3 Borrar
            try
            {
                if (opc == 1) //INSERTAR
                {
                    
                    bd.AgregaParametro("@opcion", tipoDato: TipoDato.Entero, valor: opc.ToString());
                    bd.AgregaParametro("@Nombre", tipoDato: TipoDato.Cadena, valor: this.Nombre);
                    bd.AgregaParametro("@ApPaterno", tipoDato: TipoDato.Cadena, valor: this.ApPaterno);
                    bd.AgregaParametro("@ApMaterno", tipoDato: TipoDato.Cadena, valor: this.ApMaterno);
                    bd.AgregaParametro("@FechaNacimiento", tipoDato: TipoDato.Cadena, valor: this.FechaNacimiento);

                    var dtsResult = bd.EjecutaStoredProcedure("spManejaClientes");
                }
            }
            catch (Exception)
            {
                
                throw;
            }

        }
    }
}
