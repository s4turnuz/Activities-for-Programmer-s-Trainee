// EXERCÍCIO N10:
// ==> Falta apenas o N1, N2 e N3

// ==> N1 ==> Programa para a Média de Idade DINÂMICO
int IdadeMinima2;
int IdadeMaxima2;

Console.Write("Digite a idade minima: ");
IdadeMinima2 = int.Parse(Console.ReadLine());
Console.Write("Digite a idade máxima: ");
IdadeMaxima2 = int.Parse(Console.ReadLine());

if(IdadeMaxima2>IdadeMinima2){

float IdadeMedia2 = (IdadeMinima2+IdadeMaxima2)/2;
Console.WriteLine($"A media de idade é {IdadeMedia2} anos");
}else{
    Console.WriteLine("Valores de idades inválidos!");
}

// ==> N2 ==> Euro para Real hoje (16/05/20222) = EUR 1,00 = BRL 5,27 DINÂMICO
float Qtnd_Euro2;
float Const_Conversor = 5.27f; // é constante, então não muda
Console.Write("Informe a quantidade de euros que gostaria de converter: ");
Qtnd_Euro2 = float.Parse(Console.ReadLine());
float ValorCompraReal2 = Qtnd_Euro2 * Const_Conversor;

Console.WriteLine($"{Qtnd_Euro2} Euros equivale a R${ValorCompraReal2}");

// ==> N3 ==> Comissão do vendedor de carros DINÂMICA
float ValorVendaDeCarros2;
float ComissaoVendas2;
Console.Write("Digite o valor de venda mensal: ");
ValorVendaDeCarros2 = float.Parse(Console.ReadLine());
Console.Write("Digite o % de comissão: ");
ComissaoVendas2 = int.Parse(Console.ReadLine());
float ValorComissao2 = (ValorVendaDeCarros2*ComissaoVendas2)/100;

Console.WriteLine($"O valor da comissão recebida foi de R${ValorComissao2}");
