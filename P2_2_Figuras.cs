//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0
using System.Drawing;
//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace P2_2_Figuras;

public class P2_2_Figuras
{
    static void ImprimeArea(Figura figura)
    {
        // Pongo los 2 puntos para que solo se muestren 2 decimales
        Console.WriteLine($"-Area: {figura.GetArea():0.00}");
    }
    static void Main(string[] args)
    {
        // Crear instancia de cada uno de los tipos de figuras
        Circulo circulo = new Circulo(2, Color.FromArgb(255, 50, 17, 200));
        Console.WriteLine(circulo);
        ImprimeArea(circulo);

        Rectangulo rectangulo = new Rectangulo(7, 10, Color.FromArgb(255, 89, 65, 147));
        Console.WriteLine(rectangulo);
        ImprimeArea(rectangulo);

        Trianguloequilatero triangulo = new Trianguloequilatero(9, Color.FromArgb(255, 255, 10, 10));
        Console.WriteLine(triangulo);
        ImprimeArea(triangulo);

        // Modificamos un valor cualquiera e imprimimos otra vez
        Console.WriteLine("Modificando un valor de cada figura...");
        circulo.Radio = 6;
        rectangulo.Ancho = 20;
        triangulo.Lado = 8;

        Console.WriteLine(circulo);
        ImprimeArea(circulo);
        Console.WriteLine(rectangulo);
        ImprimeArea(rectangulo);
        Console.WriteLine(triangulo);
        ImprimeArea(triangulo);

        // Creamos 3 figuras mas
        Circulo circulo2 = new Circulo(3, Color.FromArgb(255, 50, 17, 200));
        Rectangulo rectangulo2 = new Rectangulo(5, 8, Color.FromArgb(255, 89, 65, 147));
        Trianguloequilatero triangulo2 = new Trianguloequilatero(4, Color.FromArgb(255, 255, 10, 10));

        // Creamos una lista y añadimos las figuras
        Console.WriteLine("Creando lista de figuras...");
        List<Figura> figuras = new List<Figura>
        {
            circulo,
            circulo2,
            rectangulo,
            rectangulo2,
            triangulo,
            triangulo2
        };

        // Mostramos las figuras y sus areas
        foreach (Figura figura in figuras)
        {
            Console.WriteLine(figura);
            ImprimeArea(figura);
        }

        // Creamos un bucle para recorrer la lista de figuras y poner todas ellas del mismo color rgba(245, 40, 145, 200)
        foreach (Figura figura in figuras)
        {
            figura.Color = Color.FromArgb(200, 245, 40, 145);
        }

        // Creamos un bucle que recorra la lista y sume las áreas de todas las figuras y nos la muestre por pantalla
        double total = 0;
        foreach (Figura figura in figuras)
        {
            total += figura.GetArea();
        }
        Console.WriteLine($"Suma de todas las areas: {total:0.00}");
    }

}