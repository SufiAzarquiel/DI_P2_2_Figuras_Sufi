# Práctica 2.2 

Ejercicio que consiste en practicar la creacion de clases con herencia.

## Clases

[Notacion](#notacion)
La clase abstracta de la que heredan las demas es:

    Figura
    {
        _color: Color (System.Drawing)
        GetArea()
        {
            Desc: metodo abstracto donde las clases hijas calcularán el area.
        }
    }

De esta clase heredan las clases rectangulo, circulo y triangulo equilatero. Cada una añade un ToString() e implementa el GetArea(). Además añaden los siguientes atributos:

    Rectangulo
    {
        _ancho: double
        _largo: double
    }



    Circulo
    {
        _radio: double
    }



    TrianguloEquilatero
    {
        _lado: int
    }

Una vez creadas estas clases hijas, codifico la clase P2_2_Figuras:

    P2_2_Figuras
    {
        ImprimeArea(Figura figura)
        {
            Desc: Imprime el area de la figura que se le pasa como parametro usando su metodo GetArea()
        }

        Main()
        {
            Desc: Dentro del main codifico cada orden que el ejercicio pide (crear los objetos, bucles, etc). Estas instrucciones vienen detalladas en el repositorio que se indica a                 continuacion.   
        }
    }
[repositorio del profesor][proferepo]

## Notacion

Escribo las clases así: 

    NOMBRECLASE
    {
        Atributo: _tipo_ (paquete si el atributo es un objeto de una clase)
        Atributo: _tipo_
        Metodo(Class param1)
        {
            output: _tipo_
            Desc: _descripcion_
        }
    }

[proferepo]: https://github.com/jeatzr/DI_P2_2_Figuras
