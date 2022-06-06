// EXERCÍCIO N6:
// ==> Altura por peso ideal
Console.Write("Informe sua altura: "); // para trabalhar com int
float ValorAltura = float.Parse(Console.ReadLine());
float PesoIdeal = (72.7f * ValorAltura)-58;
Console.WriteLine($"Valor de peso ideal = {PesoIdeal}Kg");
