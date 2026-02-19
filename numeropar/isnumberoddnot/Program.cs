using System.ComponentModel.Design;

var numberString = string.Empty;
do
{
    Console.Write("Ingrese número o ´Salir´ para salir: ");
    numberString = Console.ReadLine();
    if (numberString!.ToLower() == "salir")
    {
        continue;
    }
    
    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El numero {numberInt},es par. ");
        }
        else
        {
            Console.WriteLine($"El numero {numberInt},es impar. ");
        }
    }
    else
    {
        Console.WriteLine($"lo que ingresaste: {numberString},no es un numero entero. ");
    }
} while (numberString! .ToLower() != "salir");
Console.WriteLine("Game over.");