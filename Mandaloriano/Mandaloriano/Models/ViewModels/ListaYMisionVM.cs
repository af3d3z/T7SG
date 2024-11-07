using BL;
using ENT;
namespace Mandaloriano.Models.ViewModels
{
    public class ListaYMisionVM
    {
        private List<Mision> _listaMisiones;
        private Mision _misionSeleccionada;

        public List<Mision> ListaMisiones {
            get { return _listaMisiones; }
        }

        public Mision MisionSeleccionada
        {
            get { return _misionSeleccionada; }
        }

        public ListaYMisionVM(int id) {
            this._listaMisiones = ListaMisionesBL.GetMisionesBL();
            this._misionSeleccionada = ListaMisionesBL.GetMision(id);
        }
    }
}
