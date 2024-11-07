using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class Mision
    {
        #region atributos
        private int _id;
        private string _titulo;
        private string _descripcion;
        private int _recompensa;
        #endregion

        #region propiedades
        public int ID {
            get { return _id; }
        }

        public string Titulo { 
            get { return _titulo; }
            set { _titulo = value; }
        }

        public string Descripcion { 
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public int Recompensa { 
            get { return _recompensa; }
            set { _recompensa = value; }
        }

        #endregion

        #region constructores
        public Mision(int id) {
            this._id = id;
        }

        public Mision(int id, string titulo, string desc, int recompensa) { 
            this._id = id;
            this._titulo = titulo;
            this._descripcion = desc;
            this._recompensa = recompensa;
        }
        #endregion
    }
}
