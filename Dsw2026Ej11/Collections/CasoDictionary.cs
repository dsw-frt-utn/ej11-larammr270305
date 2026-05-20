using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private readonly Dictionary<int, Alumno> _diccionarioAlumnos= new Dictionary<int, Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
        //  Ahora cargaremos el diccionario de alumnos
        // Add lanza una excepción si ya existe esa clave en el diccionario
        if (alumno != null)
        {
            _diccionarioAlumnos.Add(alumno.Id, alumno);
        }
    }

    // Metodo para buscar al alumno por el legajo
    public Alumno BuscarAlumno(int legajo)
    {
        if (_diccionarioAlumnos.ContainsKey(legajo))
        {
            return _diccionarioAlumnos[legajo];
        }

        return null; // Retornamos un null si no se encuentra el legajo
    }

    // Metodo para retornar el diccionario
    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return _diccionarioAlumnos;
    }

    // Metodo para eliminar un alumno mediante su clave
    public void EliminarAlumno(int legajo)
    {
        _diccionarioAlumnos.Remove(legajo);
    }

}
