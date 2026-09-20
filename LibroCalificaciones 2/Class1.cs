using System;
//Fig. 5.7: LibroCalificaciones.cs
//Clase LibroCalificaciones que resuelve el problema del promedio de la clase 
// usando la repetición controlada por un centinela.
public class LibroCalificaciones
{
    private string nombreCurso; // nombre del curso que representa este LibroCalificaciones

    // el constructor inicializa nombreCurso
    public LibroCalificaciones(string nombre)
    {
        NombreCurso = nombre; // Inicializa nombreCurso utilizando la propiedad
    } // fin del constructor

    public string NombreCurso
    {
        get { return nombreCurso; } // fin de get
        set { nombreCurso = value; } // set debería validad
    } // fin de la propiedad NombreCurso

    //Muestra un mensaje de bienvenida al usuario de LibroCalificaciones
    public void MostrarMensaje()
    {
        Console.WriteLine("Bienvenido al libro de calificaciones para\n{0}!\n", NombreCurso);
    }

    public void DeterminarPromedioClase()
    {
        int total;
        int contadorCalif;
        int calificacion;
        double promedio;

        // fase de inicialización
        total = 0;
        contadorCalif = 0;

        // fase de procesamiento
        //mensaje de recibir como entrada la calificación del usuario
        Console.Write("Escriba calificación o -1 para salir: ");
        calificacion = Convert.ToInt32(Console.ReadLine());

        while (calificacion != -1)
        {
            total = total + calificacion;
            contadorCalif = contadorCalif + 1;

            Console.Write("Escriba calificación o -1 para salir: ");
            calificacion = Convert.ToInt32(Console.ReadLine());
        } // fin de while

        // fase de terminación
        if (contadorCalif != 0)
        {
            promedio = (double)total / contadorCalif;
            Console.WriteLine("\nEl total de las {0} calificaciones introducidas es {1}", contadorCalif, total);
            Console.WriteLine("El promedio de las calificaciones es {0:F2}", promedio);
        }
        //fin de if
        else
        {
            Console.WriteLine("No se introdujeron calificaciones");
        } // fin de else
    } // fin del método DeterminarPromedioClase
} // fin de la clase LibroCalificaciones