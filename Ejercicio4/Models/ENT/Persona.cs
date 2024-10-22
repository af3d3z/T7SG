namespace Ejercicio4.Models.ENT
{
    public class Persona
    {
        #region Propiedades
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public int Edad { get; set; }
        public int IdDepartamento { get; set; }
        #endregion

        #region constructores
        public Persona(String Nombre, String Apellidos, int Edad, int IdDepartamento)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Edad = Edad;
            this.IdDepartamento = IdDepartamento;
        }

        public Persona(Persona p) {
            this.Nombre = p.Nombre;
            this.Apellidos=p.Apellidos;
            this.Edad = p.Edad; 
            this.IdDepartamento = p.IdDepartamento;
        }
        #endregion
    }
}
