using System;

Console.WriteLine("Ingrese  dos numeros");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Que numero desea hacer con los numeros");
Console.WriteLine("presione 1 para sumar");
Console.WriteLine("presione 2 para restar");
Console.WriteLine("presione 3 para multiplicar");
Console.WriteLine("presione 3 para dividir");

int numsw = int.Parse(Console.ReadLine());

switch (numsw)
{
    case 1:
        Console.WriteLine($" La suma es: {num1 + num2} ");
        break;
    case 2:
        Console.WriteLine($" La resta es: {num1 - num2} ");
        break;

    case 3:
        Console.WriteLine($" La multiplicacion es: {num1 * num2} ");
        break;
    case 4:
        Console.WriteLine($" La division es: {num1 / num2} ");
        break;
    default: Console.WriteLine("adios"); break;
}