//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0
using System.Drawing;
//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace P2_2_Figuras;

public class P2_2_Figuras
{
    static void Main(string[] args)
    {
        // Crear instancia de cada uno de los tipos de figuras
        Circulo circulo = new Circulo(2, Color.FromArgb(255, 50, 17, 200));
        Console.WriteLine("Creando instancia de Circulo...");
        Console.WriteLine(circulo);
        Console.WriteLine($"Area: {circulo.GetArea()}");

        Rectangulo rectangulo = new Rectangulo(7, 10, Color.FromArgb(255, 89, 65, 147));
        Console.WriteLine("Creando instancia de Rectangulo...");
        Console.WriteLine(rectangulo);
        Console.WriteLine($"Area: {rectangulo.GetArea()}");

        Trianguloequilatero triangulo = new Trianguloequilatero(9, Color.FromArgb(255, 255, 10, 10));
        Console.WriteLine("Creando instancia de Triangulo equilatero...");
        Console.WriteLine(triangulo);
        Console.WriteLine($"Area: {triangulo.GetArea()}");

        // Modificamos un valor cualquiera e imprimimos otra vez
        Console.WriteLine("Modificando un valor de cada figura...");
        circulo.Radio = 6;
        rectangulo.Ancho = 20;
        triangulo.Lado = 8;

        Console.WriteLine(circulo);
        Console.WriteLine($"Area: {circulo.GetArea()}");
        Console.WriteLine(rectangulo);
        Console.WriteLine($"Area: {rectangulo.GetArea()}");
        Console.WriteLine(triangulo);
        Console.WriteLine($"Area: {triangulo.GetArea()}");

        // Crea
    }

}