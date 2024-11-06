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
        public static List<Mision> GetMisionesBL() {
            List<Mision> listaMisiones = new List<Mision>();
            if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour <= 8)
            {
                listaMisiones = null;
            }
            else {
                listaMisiones = ListaMisiones.GetMisiones();
            }

            return listaMisiones;
        }
    }
}
