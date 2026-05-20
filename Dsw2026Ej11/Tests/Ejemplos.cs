using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System.Numerics;
using System.Runtime.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        Console.WriteLine("========== EJEMPLO LIST ==========");

        Alumno a1 = new Alumno(1234, "Lara", 8.40);
        Alumno a2 = new Alumno(5678, "Ana", 8.90);
        Alumno a3 = new Alumno(4567, "Astrid", 9.99);

        CasoList casoList = new CasoList();

        // Agregar 3 alumnos a la lista
        casoList.AgregarAlumno(a1);
        casoList.AgregarAlumno(a2);
        casoList.AgregarAlumno(a3);

        // Listar por consola los alumnos
        Console.WriteLine("\n--- Lista Original ---");
        foreach (var alumno in casoList.ObtenerLista())
        {
            Console.WriteLine(alumno);
        }

        // Buscar por nombre un alumno que exista y mostrar por consola
        Console.WriteLine("\n--- Buscando 'Ana' ---");
        var encontrada = casoList.BuscarAlumno("Ana");
        Console.WriteLine(encontrada != null ? encontrada.ToString() : "No existe");

        // Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
        Console.WriteLine("\n--- Buscando 'Pedro' ---");
        var noEncontrada = casoList.BuscarAlumno("Pedro");
        Console.WriteLine(noEncontrada != null ? noEncontrada.ToString() : "No existe");

        // Eliminar un alumno y listar por consola los alumnos
        Console.WriteLine("\n--- Lista tras eliminar a 'Lara' ---");
        casoList.EliminarAlumno(a1);
        foreach (var alumno in casoList.ObtenerLista())
        {
            Console.WriteLine(alumno);
        }

        // Eliminar el primer elemento de la lista y listar por consola los alumnos
        Console.WriteLine("\n--- Lista tras eliminar el primer elemento ---");
        casoList.EliminarPosicion(0);
        foreach (var alumno in casoList.ObtenerLista())
        {
            Console.WriteLine(alumno);
        }
    }

    public static void EjemploDictionary()
    {
        Console.WriteLine("\n========== EJEMPLO DICTIONARY ==========");

        Alumno a1 = new Alumno(1234, "Lara", 8.40);
        Alumno a2 = new Alumno(5678, "Ana", 8.90);
        Alumno a3 = new Alumno(4567, "Astrid", 9.99);

        CasoDictionary casoDict = new CasoDictionary();

        // Agregar 3 alumnos al diccionario
        casoDict.AgregarAlumno(a1);
        casoDict.AgregarAlumno(a2);
        casoDict.AgregarAlumno(a3);

        // Listar por consola los alumnos
        Console.WriteLine("\n--- Diccionario Original ---");
        foreach (KeyValuePair<int, Alumno> kvp in casoDict.ObtenerDiccionario())
        {
            Console.WriteLine($"Clave: {kvp.Key} -> Valor: {kvp.Value}");
        }

        // Buscar un alumno por clave y mostrar por consola
        Console.WriteLine("\n--- Buscando clave 5678 (Ana) ---");
        var encontrado = casoDict.BuscarAlumno(5678);
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        // Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
        Console.WriteLine("\n--- Buscando clave 9999 ---");
        var noEncontrado = casoDict.BuscarAlumno(9999);
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        // Eliminar un alumno por clave y listar por consola los alumnos
        Console.WriteLine("\n--- Diccionario tras eliminar clave 1234 (Lara) ---");
        casoDict.EliminarAlumno(1234);
        foreach (var kvp in casoDict.ObtenerDiccionario())
        {
            Console.WriteLine($"Clave: {kvp.Key} -> Valor: {kvp.Value}");
        }
    }

    public static void EjemploLinq()
    {
        Console.WriteLine("\n========== EJEMPLOS LINQ ==========");

        CasoLinq casoLinq = new CasoLinq();

        // 1. Obtener el primer libro (GetPrimero)
        Console.WriteLine($"\n1. Primer libro: {casoLinq.GetPrimero().Titulo}");

        // 2. Obtener el último libro (GetUltimo)
        Console.WriteLine($"2. Último libro: {casoLinq.GetUltimo().Titulo}");

        // 3. Obtener la suma de precios (GetTotalPrecios)
        Console.WriteLine($"3. Suma total de precios: {casoLinq.GetTotalPrecios():C}");

        // 4. Obtener el promedio de precios (GetPromedioPrecios)
        Console.WriteLine($"4. Promedio de precios: {casoLinq.GetPromedioPrecios():C}");

        // 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
        Console.WriteLine("\n5. Libros con Id mayor a 15:");
        foreach (var libro in casoLinq.GetListById())
        {
            Console.WriteLine($"   - {libro.Id}: {libro.Titulo}");
        }

        // 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros)
        Console.WriteLine("\n6. Libros en formato string:");
        foreach (var textoLibro in casoLinq.GetLibros())
        {
            Console.WriteLine($"   {textoLibro}");
        }

        // 7. Obtener el libro con el precio más alto (GetMayorPrecio)
        Console.WriteLine($"\n7. Libro más caro: {casoLinq.GetMayorPrecio().Titulo} ({casoLinq.GetMayorPrecio().Precio:C})");

        // 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
        Console.WriteLine($"8. Libro más barato: {casoLinq.GetMenorPrecio().Titulo} ({casoLinq.GetMenorPrecio().Precio:C})");

        // 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
        Console.WriteLine("\n9. Libros con precio mayor al promedio:");
        foreach (var libro in casoLinq.GetMayorPromedio())
        {
            Console.WriteLine($"   - {libro.Titulo} ({libro.Precio:C})");
        }

        // 10. Obtener los libros ordenados por título de forma descendente
        Console.WriteLine("\n10. Libros ordenados por título (Z-A):");
        foreach (var libro in casoLinq.GetOrdenadosPorTituloDesc())
        {
            Console.WriteLine($"   - {libro.Titulo}");
        }
    }
}
