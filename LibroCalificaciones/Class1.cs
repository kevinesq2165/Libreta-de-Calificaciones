using System;
//Fig 5.5: LibroCalificaciones.cs
//Clase LibroCalificaciones que resuelve el problema del promedio de la casle
// utilizando la repetición conytolada por un contador.


public class LibroCalificaciones{
    private string nombreCurso; // nombre del curso que corresponde LibroCalifacones

// El constructor inicializa nombreCurso
public LibroCalificaciones(string nombre)
    {
        NombreCurso = nombre;
    }// Fin constructor

// propiedad para obtener (get) y establecer (set) el nombre del curso
 public string NombreCurso
    {
     get { return nombreCurso; }// fin get
     set { nombreCurso = value; }// debería validar
    }
//muestra un mensaje de bienvenida para el usuarui de LibroCalificaciones
public void MostrarMensaje()
    {
        //la propiedad NombreCurso obtiene el nombre del curso
        Console.WriteLine("Bienvenido al libro de calificaciones de \n {0}!", NombreCurso);
    }//fin del metodo MostrarMensaje
    //determinar el promedio de la clase con base en las 10 califiaciones introducción por el usuario

public void DeterminarPromedioClase()
    {
        int total; // suma de las califiaciones introducidas por el usuario
        int contadorCalif; // número de la siguiente calificación a introducir
        int calificacion; // valor de la calificacion introducida por el usuario
        int promedio; // promedio de las calificaciones
        // fase de inicialización
        total = 0; // inicializa el total
        contadorCalif = 1; // inicializa el contador del ciclo

        // fase de procesamiento 
        while (contadorCalif <= 10) //itera 10 veces 
        {
            Console.Write("Escriba  calificación:"); // mensaje para el usuario
            calificacion = Convert.ToInt32(Console.ReadLine()); // lee calificación
            total = total + calificacion;// suma calificación al total
            contadorCalif = contadorCalif + 1; // incremetna el contador en 1

        }// fin while

        // fase de terminación
        promedio = total / 10; // división entera produce resultado entero

        Console.WriteLine("\nEl total de las 10 calificaciones es {0}", total);
        Console.WriteLine("El promedio de la clase es {0}", promedio);
    } // fin del método DeterminarPromedioClase
} // fin de la clase LibroCalificaciones
    



