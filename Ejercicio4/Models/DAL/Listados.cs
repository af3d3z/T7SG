using Ejercicio4.Models.ENT;

namespace Ejercicio4.Models.DAL
{
    public class Listados
    {
        public static List<Persona> ObtenerPersonas() { 
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona("Manolo", "Morilla Moreno", 31, 2));
            personas.Add(new Persona("Pablo", "Scooters", 50, 1));
            personas.Add(new Persona("Juan Antonio", "Pineda", 20, 3));
            personas.Add(new Persona("Francisco", "Espejo", 20, 2));

            return personas;
        }

        public static List<Departamento> ObtenerDepartamentos() {
            List<Departamento> departamentos = new List<Departamento>();
            departamentos.Add(new Departamento(1, "Ventas"));
            departamentos.Add(new Departamento(2, "Reparaciones"));
            departamentos.Add(new Departamento(3, "Administración"));
            return departamentos;
        }
    }
}
