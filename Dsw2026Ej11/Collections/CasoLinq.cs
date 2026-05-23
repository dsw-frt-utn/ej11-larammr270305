using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    //private readonly List<Libro> _listaLibros = new List<Libro>();

    private readonly List<Libro> _listaLibros = Libro.CrearLista();
0
0    // Obtenemos el primer libro de la lista
    public Libro GetPrimero() => _listaLibros.First();

    // Obtenemos el ultimo libro de la lista
    public Libro GetUltimo() => _listaLibros.Last();

    // Obtenemos la suma total de los precios de los libros de la lista
    public decimal GetTotalPrecios() => _listaLibros.Sum(l => l.Precio);

    // Obtenemos el promedio total de la suma de los precios de la lista
    public decimal GetPromedioPrecios() => _listaLibros.Average(l => l.Precio);

    // Obtenemos la lista de libros con ID mayor a 15

    public IEnumerable<Libro> GetListById() => _listaLibros.Where(l => l.Id > 15);

    // Obtener una lista de cada libro con su titulo y precio en formato moneda
    public IEnumerable<string> GetLibros() => _listaLibros.Select(l => $"{l.Titulo} - {l.Precio:C}");

    // Obtener el libro con el precio mas alto
    // Primero ordenamos de menor a mayor y luego obtenemos el último
    public Libro GetMayorPrecio() => _listaLibros.OrderBy(l => l.Precio).Last();

    //Obtener el libro con el precio mas bajo
    // Primero ordenamos de menor a mayor y luego obtenemos el primero
    public Libro GetMenorPrecio() => _listaLibros.OrderBy(l => l.Precio).First();

    // Obtenemos los libros cuyo preico sea mayor al promedio
    public List<Libro> GetMayorPromedio()
    {
        var promedio = GetPromedioPrecios();

        return _listaLibros.Where(l => l.Precio > promedio).ToList();
    }

    // Obtenemos los libros ordenados por titulo de forma descendiente
    public IEnumerable<Libro> GetOrdenadosPorTituloDesc() => _listaLibros.OrderByDescending(l => l.Titulo);
}
