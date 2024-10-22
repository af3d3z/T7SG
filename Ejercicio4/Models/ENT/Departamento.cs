namespace Ejercicio4.Models.ENT {

    public class Departamento
    {
        #region propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        #endregion

        #region constructores
        public Departamento(int Id, string Nombre)
        {
            this.Id = Id;
            this.Nombre = Nombre;
        }
        #endregion
    }
}
