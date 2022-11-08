using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Medicamentos
    {
        private CD_Medicamentos objetoCD = new CD_Medicamentos();

        public DataTable MostrarMed()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void CrearMed(string nombre, string desc, string efectosSec, string marca, string precio, string stock)
        {
            objetoCD.Insertar(nombre, desc, efectosSec, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }

        public void EditarMed(string nombre, string desc, string efectosSec, string marca, string precio, string stock, string id)
        {
            objetoCD.Editar(nombre, desc, efectosSec, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(id));
        }

        public void EliminarMed(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
