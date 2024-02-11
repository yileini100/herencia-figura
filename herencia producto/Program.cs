// See https://aka.ms/new-console-template for more information
using herencia_producto;

Console.WriteLine(" FIGURAS GEOMETRICAS ");
Console.WriteLine();

Console.WriteLine("CALCULO CUADEADO");
Console.WriteLine();

Cuadrado cuadrado = new Cuadrado();
Console.WriteLine("Lado A: ");
cuadrado.LadoA=double.Parse(Console.ReadLine());
Console.WriteLine("LadoB: ");
cuadrado.LadoB=double.Parse(Console.ReadLine());

double resultado = cuadrado.CalcularArea();
double perimetro = cuadrado.CalcularPerimetro();

Console.WriteLine("EL area de un cuadrado es " + resultado);
Console.WriteLine($"EL perimetro del cuadrado es {perimetro}");
Console.WriteLine();



Console.WriteLine("CALCULO TRIANGULO");
Console.WriteLine();

triangulo triangulo = new triangulo();
Console.WriteLine("Lado A: ");
triangulo.LadoA = double.Parse(Console.ReadLine());
Console.WriteLine("LadoB: ");
triangulo.LadoB = double.Parse(Console.ReadLine());

double resultaddo = triangulo.CalcularArea();
double perimetrro = triangulo.CalcularPerimetro();

Console.WriteLine("EL area de un triangulo es " + resultaddo);
Console.WriteLine($"EL perimetro del triangulo es {perimetrro}");
Console.WriteLine();




Console.WriteLine("CALCULO TRIANGULO");
Console.WriteLine();

Circulo circulo = new Circulo();
Console.WriteLine("radio: ");
circulo.radio = double.Parse(Console.ReadLine());

double resul = circulo.CalcularArea();
double perime = circulo.CalcularPerimetro();

Console.WriteLine("EL area de un circulo es " + resultaddo);
Console.WriteLine($"EL perimetro del circulo es {perimetrro}");



