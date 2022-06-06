// EXERCÍCIO N4:
// ==> Conversor Celsius  para  Fahrenheit
Console.Write("Digite a temp em Cº: ");
float ValorCelsius = float.Parse(Console.ReadLine());
float ValorFahrenheit = (9*ValorCelsius+160)/5;
Console.WriteLine($"Cº{ValorCelsius} = Fº{ValorFahrenheit}");
