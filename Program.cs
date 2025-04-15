using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Xml;
{
    Console.WriteLine("ingrese un nombre:");
    string nombre = Console.ReadLine();

    while (nombre == "")
    {
        Console.WriteLine("Por favor , ingrese un nombre:");
        nombre = Console.ReadLine();
    }
    {
        Console.WriteLine("ingrese la cantidad de notas (entre 1 y 5):");
        int cantidad = int.Parse(Console.ReadLine());

        double Suma = 0;
        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write("Ingresa la nota #" + i + " (entre 1 y 10): ");
            double nota = double.Parse(Console.ReadLine());
            if (nota >= 1 && nota <= 10)
            {
                Suma += nota;
            }
            else Console.Write("ingrese una nota valida (entre 1 y 10)");

        }

        double promedio = Suma / cantidad;
        Console.WriteLine("el promedio es:" + promedio);

        if (promedio >= 9)
        {
            Console.WriteLine("Clasificación: Excelente");
        }
        else if (promedio >= 7)
        {
            Console.WriteLine("Clasificación: Bueno");
        }
        else if (promedio >= 6)
        {
            Console.WriteLine("Clasificación: Regular");
        }
        else
        {
            Console.WriteLine("Clasificación: Reprobado");
        }
    }
}
            
        
    


        
        
        

