// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int suma, resta, multiplicacion, división, residuo, num1, num2;
String linea, linea2;
Console.WriteLine("Ingrese primer numero");
linea = Console.ReadLine();
Console.WriteLine("Ingrese segundo numero");
linea2 = Console.ReadLine();
num1 = int.Parse(linea);
num2 = int.Parse(linea2);
suma = num1 + num2;
resta = num1 - num2;
multiplicacion = num1 * num2;
división = num1 / num2;
residuo = num1 % num2;
Console.WriteLine("La suma es... " + suma);
Console.WriteLine("La resta es... " + resta);
Console.WriteLine("La multiplicacion es... " + multiplicacion);
Console.WriteLine("La division es... " + división);
Console.WriteLine("El residuo de la división es... " + residuo);
Console.ReadKey();