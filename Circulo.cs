using System.Drawing;

namespace P2_2_Figuras;

internal class Circulo : Figura
{
    protected double _radio;

    public Circulo(double radio, Color color)
    {
        _radio = radio;
        _color = color;
    }

    public double Radio
    {
        get => _radio;
        set => _radio = value;
    }

    public override double GetArea()
    {
        // El area de un circulo es PI * radio^2
        return Math.PI * Math.Pow(_radio, 2);
    }

    public override string ToString()
    {
        return $"FIGURA CIRCULO \n-Radio: {_radio}\n-Color: {_color}";
    }
}