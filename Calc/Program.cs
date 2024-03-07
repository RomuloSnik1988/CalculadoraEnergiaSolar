using Calc.Entities;
using System.Globalization;

CalculadoraSolar calc = new CalculadoraSolar();

Console.WriteLine("Calcular a Quantidade de Módulos fotovoltaicos");
Console.WriteLine();
Console.Write("Informe Seu Consumo de Energia em Kwh: ");
calc.Consumo = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(calc);
Console.ReadLine();