using Ejercicio4.Models.DAL;
using Ejercicio4.Models.ENT;

public class EditarPersonasVM : Persona
{
    #region parametros
    public List<Departamento> departamentos { get; }
    #endregion

    public EditarPersonasVM(Persona p): base(p)
    {
        this.Nombre = p.Nombre;
        this.Apellidos = p.Apellidos;
        this.Edad = p.Edad;
        this.IdDepartamento = p.IdDepartamento;
        this.departamentos = Listados.ObtenerDepartamentos();
    }
}