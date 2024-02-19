using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese sus nombres:");
        string nombres = Console.ReadLine();

        Console.WriteLine("Ingrese sus apellidos:");
        string apellidos = Console.ReadLine();

        // Longitud por separado de nombres, apellidos y nombre completo
        int longitudNombres = ContarCaracteresSinEspacios(nombres);
        int longitudApellidos = ContarCaracteresSinEspacios(apellidos);
        int longitudNombreCompleto = longitudNombres + longitudApellidos;

        // Mostrar longitud por separado
        Console.WriteLine("\nLongitud de nombres: " + longitudNombres);
        Console.WriteLine("Longitud de apellidos: " + longitudApellidos);
        Console.WriteLine("Longitud de nombre completo: " + longitudNombreCompleto);

        // Mostrar nombre completo
        string nombreCompleto = nombres + " " + apellidos;
        Console.WriteLine("\nNombre completo: " + nombreCompleto);

        // Mostrar nombre completo reemplazando espacios por underscore (_)
        string nombreCompletoUnderscore = nombreCompleto.Replace(' ', '_');
        Console.WriteLine("Nombre completo con espacios reemplazados por underscore: " + nombreCompletoUnderscore);

        // Mostrar nombres en mayúscula
        string nombresMayuscula = nombres.ToUpper();
        Console.WriteLine("Nombres en mayúscula: " + nombresMayuscula);

        // Mostrar apellidos en minúscula
        string apellidosMinuscula = apellidos.ToLower();
        Console.WriteLine("Apellidos en minúscula: " + apellidosMinuscula);

        // Mostrar primer carácter del apellido
        char primerCaracterApellido = apellidos[0];
        Console.WriteLine("Primer carácter del apellido: " + primerCaracterApellido);

        // Mostrar último carácter del nombre
        char ultimoCaracterNombre = nombres[nombres.Length - 1];
        Console.WriteLine("Último carácter del nombre: " + ultimoCaracterNombre);
    }

    static int ContarCaracteresSinEspacios(string cadena)
    {
        int contador = 0;
        foreach (char caracter in cadena)
        {
            if (caracter != ' ')
            {
                contador++;
            }
        }
        return contador;
    }
}
