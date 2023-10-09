# Práctica 2.2 

En esta práctica tendremos que implementar clases que hereden de la clase abstract *Figura*, crearemos instancias de ellas y las guardaremos en un objeto tipo *List* para luego recorrerlo
y mostrar las características de todas ellas (las figuras) en modo texto por consola, con independencia de la subclase a la que pertenezcan.

Esta práctica se entregará mediante un enlace a GitHub de vuestro repositorio.
Recordad que las carpetas _bin_ y _obj_ no hace falta que estén incluidas en los commits, ya que se 
generan de manera automática al compilar y ejecutar el proyecto.


## En primer lugar
Comenzaremos clonando este repositorio en nuestro disco duro. 
Crearemos un repositorio propio en github llamado **P2_2_Figuras** e iremos subiendo de manera sucesiva los avances haciendo la práctica. No se permite subir de golpe todo el proyecto. De esta manera el profesor puede ver los avances hechos paso a paso. 
**El repositorio ha de ser privado para evitar plagio y solo se hará público cuando finalice la entrega de la tarea**
No se permitirán _commits_ después de la fecha límite de entrega. 
En el fichero de descripción del repositorio **README.md** pondremos el nombre del autor o autora de la práctica así como una breve descripción de la misma. 



## En segundo lugar
Crearemos las subclases que hereden de la clase abstract *Figura*
Hay que tener en cuenta que los métodos constructores de cada una de las figuras han de
aceptar el *color* (que ha de ser una estructura *Color*) como parámetro de entrada y ya ,dependiendo de cada figura, los otros parámetros necesarios. 
Crearemos al menos las siguientes clases para distintos tipos de figuras:
- Rectángulo ( tendrá una base y una altura)
- Círculo (Tendrá un radio)
- TriánguloEquilátero (tendrá la longitud del lado)
  
Los atributos propios de las clases creadas tendrán que declararse con un modificador de acceso que permita acceder desde dentro de la propia clase y desde cualquier clase derivada (en el ensamblado o no).
Tendremos que crear por lo tanto métodos *getters* y *setters* para esos atributos. 

Cada una de las clases ha de implementar sobreescribiendo el método *GetArea()*, el cual será 
distinto en cada figura, por razones obvias. 
También sobreescribiremos el método *ToString()* para que cuando intentemos 
mostrar por consola una figura nos salga en un formato similar a esto:
________________________
FIGURA RECTANGULO
- Alto:3
- Ancho:3.9
- Color: Color [A=255, R=50, G=20, B=34]

## En tercer Lugar
En el Main, crearemos una instancia de cada uno de las figuras programadas y las mostraremos por consola, así como mostraremos el área de cada una de ellas.
Modificaremos algún parámetro de cada una de las figuras y volveremos a mostrarlas por consola para
ver que el cambio se ha llevado a cabo. 

## En cuarto  lugar 
En el Main crearemos una instancia de *List* llamado **lista_figuras** que pueda contener objetos tipo *Figura*.

Crearemos 6 instancias de figuras distintas de los tipos creados y los añadiremos a dicha lista.

Crearemos un bucle para recorrer la Lista y mostrar cada una de las figuras por consola junto con su área de cada una:

### La salida para imprimir el objeto lista_figuras ha de quedar algo similar a esto

________________________
FIGURA RECTANGULO
- Alto:3
- Ancho:3.9
- Color: Color [A=255, R=50, G=20, B=34]
- Area: 11.7
_____________________
FIGURA CÍRCULO
- Radio:4
- Color: Color [A=255, R=0, G=20, B=35]
- Area: 50.26
_____________________
FIGURA CÍRCULO
- Radio:2
- Color: Color [A=255, R=230, G=20, B=30]
- Area: 12.56
_____________________
FIGURA TRIÁNGULO EQUILÁTERO
- Lado:3
- Color: Color [A=255, R=0, G=20, B=40]

## En quinto lugar

Crearemos un bucle para recorrer la lista de figuras y poner todas ellas del mismo color
rgba(245, 40, 145, 200)

## En sexto lugar

Crearemos un bucle que recorra la lista y sume las áreas de todas las figuras y nos la muestre por pantalla.


