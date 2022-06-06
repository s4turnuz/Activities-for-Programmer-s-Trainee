// EXERCÍCIO N5:
// ==> Conversor Fahrenheit para Celsius
Console.Write("Digite a temp em Fº: ");
float ValorFahrenheit2 = float.Parse(Console.ReadLine());
float ValorCelsius2 = (ValorFahrenheit2-32)*5/9;
Console.WriteLine($"Fº{ValorFahrenheit2} = Cº{ValorCelsius2}");
