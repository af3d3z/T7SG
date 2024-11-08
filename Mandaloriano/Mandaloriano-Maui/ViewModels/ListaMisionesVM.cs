using ENT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Maui.Controls;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mandaloriano_Maui.ViewModels
{
    public class ListaMisionesVM : INotifyPropertyChanged
    {
        private Mision _mision;
        private List<Mision> _listaMisiones;
        private Boolean _mostrarError = false;
        private Boolean _mostrarPicker = true;

        public List<Mision> ListaMisiones { 
            get {
                _listaMisiones = BL.ListaMisionesBL.GetMisionesBL();
                if (_listaMisiones == null)
                {
                    _mostrarError = true;
                    _mostrarPicker = false;
                    INotifyPropertyChanged("MostrarError");
                    INotifyPropertyChanged("MostrarPicker");
                }

                return _listaMisiones;
            } 
        }


        public Mision Mision { 
            get { return _mision; }
            set { 
                _mision = value;
                INotifyPropertyChanged("Mision");
            } 
        }

        public Boolean MostrarError {
            get { return _mostrarError;  }
        }

        public Boolean MostrarPicker
        {
            get { return _mostrarPicker; }
        }

        public ListaMisionesVM() { }

        public ListaMisionesVM(int idMision) {
            this.Mision = BL.ListaMisionesBL.GetMision(idMision);
        }


        #region Notify
        private void INotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        #endregion
    }
}
