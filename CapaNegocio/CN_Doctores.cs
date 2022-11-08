using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Doctores
    {
        private CD_Doctores objetoCD = new CD_Doctores();

        public DataTable MostrarDoc()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void CrearDoc(string nombre, string apellido, int edad, string genero, string especialidad, string codigo, string contraMedico)
        {
            objetoCD.Insertar(nombre, apellido, Convert.ToInt32(edad), genero, especialidad, codigo, contraMedico);
        }

        public void EditarDoc(string nombre, string apellido, string edad, string genero, string especialidad, string codigo, string contraMedico, string id)
        {
            objetoCD.Editar(nombre, apellido, Convert.ToInt32(edad), genero, especialidad, codigo, contraMedico, Convert.ToInt32(id));
        }

        public void EliminarDoc(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
