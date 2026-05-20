using Dsw2026Ej11.Domain;
namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private readonly List<Alumno> _listaAlumnos = new List<Alumno>();

    // Metodo para agregar alumnos con .Add
    public void AgregarAlumno(Alumno alumno)
    {
        if (alumno != null)
        {
            _listaAlumnos.Add(alumno);
        }
    }

    public List<Alumno> ObtenerLista()
    {
        return _listaAlumnos;
    }

    //Metodo para buscar al alumno mediante el nombre como parametro

    public Alumno BuscarAlumno(string nombre)
    {
        Alumno coincidencia = _listaAlumnos.Find(a => a.Nombre == nombre);
        return coincidencia;
    }

    // Metodo para eliminar un alumno en especifico
    public void EliminarAlumno(Alumno alumno)
    {
        if (alumno != null)
        {
            _listaAlumnos.Remove(alumno);
        }
    }

    // Metodo para eliminar un alumno en una posicion especifica
    public void EliminarPosicion(int posicion)
    {

        if (posicion >= 0 && posicion < _listaAlumnos.Count)
        {
            _listaAlumnos.RemoveAt(posicion);
        }
    }
}
