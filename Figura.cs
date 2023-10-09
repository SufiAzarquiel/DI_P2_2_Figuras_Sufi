using System.Drawing;
using System.Dynamic;

namespace P2_2_Figuras;

internal abstract class Figura
{
    protected Color _color;

    public abstract double GetArea();

    public Color Color
    {
        get => _color;
        set => _color = value;
    }
}