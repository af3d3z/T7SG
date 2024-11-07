using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ListaMisiones
    {
        /// <summary>
        /// Devuelve la lista de misiones
        /// </summary>
        /// <returns></returns>
        public static List<Mision> GetMisiones() {
            List<Mision> misiones = new List<Mision>();
            misiones.Add(new Mision(1, "Rescate de Baby Yoda", "Debes hacerte con Grogu y llevárselo a Luke SkyWalker para su entrenamiento.", 5000));
            misiones.Add(new Mision(2, "Recuperar armadura Beskar", "Tu armadura de Beskar ha sido robada. Debes encontrarla.", 2000));
            misiones.Add(new Mision(3, "Planeta Sorgon", "Debes llevar a un niño de vuelta a su planeta natal \"Sorgon\".", 500));
            misiones.Add(new Mision(4, "Renacuajos", "Debes llevar a una Dama Rana y sus huevos de Tatooine a la luna del estuario Trask, donde su esposo fertilizará los huevos.", 500));
            return misiones;
        }

        /// <summary>
        /// Devuelve una misión en base al ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Mision GetMision(int id) {
            Mision misionSeleccionada = null;
            foreach (Mision mision in GetMisiones()) {
                if (id == mision.ID) {
                    misionSeleccionada = mision;
                }
            }

            return misionSeleccionada;
        }
    }
}
