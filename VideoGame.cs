/*
Una compañía de videojuegos te ha contratado para escribir el programa de un videojuego
nuevo.
Deberás crear la parte del programa que calcula el número total de puntos que un
jugador gana en el juego Galaxy.
Los jugadores acumulan puntos mediante la recolección de objetos.
Los objetos tienen asignados los siguientes puntos:
Estrella = 10 puntos.
Planeta = 20 puntos.
Asteroide = 50 puntos.
Cometa = 100 puntos.
Si un jugador acumula más de 5.000 puntos, en una misma jugada, ganará un bono de
500 puntos.
Implementa pues una jugada, donde le pidamos al usuario el nombre de un objeto y el
número de estos que ha recogido. Mostrando el total de puntos teniendo en cuenta los bonos.
Nota: Usar un switch para decidir los puntos del objeto.
*/

using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Bienvenido al juego Galaxy");
        Console.Write("Ingresa el nombre del objeto (Estrella/Planeta/Asteroide/Cometa): ");
        string nombreObjeto = Console.ReadLine();

        Console.Write("Ingresa la cantidad de objetos que has recogido: ");
        int cantidadObjetos = int.Parse(Console.ReadLine());

        int puntos = 0;

        switch (nombreObjeto.ToLower())
        {
            case "estrella":
                puntos = cantidadObjetos * 10;
                break;
            case "planeta":
                puntos = cantidadObjetos * 20;
                break;
            case "asteroide":
                puntos = cantidadObjetos * 50;
                break;
            case "cometa":
                puntos = cantidadObjetos * 100;
                break;
            default:
                Console.WriteLine("Objeto no válido. Por favor, ingresa un objeto válido.");
                return;
        }

        if (puntos > 5000)
        {
            puntos += 500; // Aplicar el bono de 500 puntos.
            Console.WriteLine($"¡Has ganado un bono de 500 puntos!");
        }

        Console.WriteLine($"Has ganado {puntos} puntos en total.");
    }
}
