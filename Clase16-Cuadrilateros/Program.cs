using Clase16_Cuadrilateros.Modelos;

Console.WriteLine("Este programa calcula el área de un cuadrilatero (rectángulo, cuadrado y trapecio)");
Console.WriteLine("A continuación ingrese los 4 vertices que conforman el cuadrilatero");

Console.WriteLine("Primer vértice: Ingrese el valor x");
int valorX1 = int.Parse(Console.ReadLine());
Console.WriteLine("Primer vértice: Ingrese el valor y");
int valorY1 = int.Parse(Console.ReadLine());

Console.WriteLine("Segundo vértice: Ingrese el valor x");
int valorX2 = int.Parse(Console.ReadLine());
Console.WriteLine("Segundo vértice: Ingrese el valor y");
int valorY2 = int.Parse(Console.ReadLine());

Console.WriteLine("Tercer vértice: Ingrese el valor x");
int valorX3 = int.Parse(Console.ReadLine());
Console.WriteLine("Tercer vértice: Ingrese el valor y");
int valorY3 = int.Parse(Console.ReadLine());

Console.WriteLine("Cuarto vértice: Ingrese el valor x");
int valorX4 = int.Parse(Console.ReadLine());
Console.WriteLine("Cuarto vértice: Ingrese el valor y");
int valorY4 = int.Parse(Console.ReadLine());

Console.Clear();

Console.WriteLine("Elija la opción que desee");
Console.WriteLine("1- Área de un rectángulo");
Console.WriteLine("2- Área de un cuadrado");
Console.WriteLine("3- Área de un trapecio");
Console.WriteLine("4- Salir");

int opcion = int.Parse(Console.ReadLine());


switch (opcion)
{

    case 1:
        Rectangulo nuevoRectangulo = new Rectangulo(valorX1, valorY1, valorX2, valorY2, valorX3, valorY3, valorX4, valorY4);
        Console.WriteLine("El área del rectángulo es: " + nuevoRectangulo.Area());
        break;

    case 2:
        Cuadrado nuevoCuadrado = new Cuadrado(valorX1, valorY1, valorX2, valorY2, valorX3, valorY3, valorX4, valorY4);
        Console.WriteLine("El área del cuadrado es: " + nuevoCuadrado.Area());
        break;

    case 3:
        Trapecio nuevoTrapecio = new Trapecio(valorX1, valorY1, valorX2, valorY2, valorX3, valorY3, valorX4, valorY4);
        Console.WriteLine("El área del trapecio es: " + nuevoTrapecio.Area());
        break;

    case 4:
        break;

    default:
        Console.WriteLine("Opción inválida");
        break;
}

Console.ReadKey();