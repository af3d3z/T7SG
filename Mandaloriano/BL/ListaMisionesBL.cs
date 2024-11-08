using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ListaMisionesBL
    {
        /// <summary>
        /// Aplica las restricciones del negocio y devuelve una lista si cumple con lo estipulado
        /// Postcondition: Devuelve nulo si se accede entre las 12 y las 8 AM
        /// </summary>
        /// <returns></returns>
        public static List<Mision> GetMisionesBL() {
            List<Mision> listaMisiones = new List<Mision>();
            if (DateTime.Now.Hour <= 8)
            {
                listaMisiones = null;
            }
            else {
                listaMisiones = ListaMisiones.GetMisiones();
            }

            return listaMisiones;
        }

        /// <summary>
        /// Devuelve una misión por su ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Mision GetMision(int id) { 
            return ListaMisiones.GetMision(id);
        }
    }
}
