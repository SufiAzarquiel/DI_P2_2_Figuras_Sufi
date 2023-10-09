using System.Drawing;

namespace P2_2_Figuras;

internal class Rectangulo : Figura
{
    protected double _ancho;
    protected double _alto;

    public Rectangulo(double ancho, double alto, Color color)
    {
        _ancho = ancho;
        _alto = alto;
        _color = color;
    }

    public double Ancho
    {
        get => _ancho;
        set => _ancho = value;
    }

    public double Alto
    {
        get => _alto;
        set => _alto = value;
    }

    public override double GetArea()
    {
        return _ancho * _alto;
    }

    public override string ToString()
    {
        return $"FIGURA RECTANGULO \n-Ancho: {_ancho}\n-Alto: {_alto}\n-Color: {_color}";
    }
}