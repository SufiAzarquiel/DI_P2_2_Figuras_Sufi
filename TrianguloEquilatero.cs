using System.Drawing;

namespace P2_2_Figuras;

internal class Trianguloequilatero : Figura
{
    protected int _lado;

    public Trianguloequilatero(int lado, Color color)
    {
        _lado = lado;
        _color = color;
    }

    public int Lado
    {
        get => _lado;
        set => _lado = value;
    }

    public override double GetArea()
    {
        // El area de un triangulo equilatero es (lado^2 * √3) / 4
        return (Math.Pow(_lado, 2) * Math.Sqrt(3)) / 4;
    }

    public override string ToString()
    {
        return $"FIGURA TRIANGULO EQUILATERO \n-Lado: {_lado}\n-Color: {_color}";
    }
}