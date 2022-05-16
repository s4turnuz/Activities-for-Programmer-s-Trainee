// EXERCÍCIO N1:
// ==> Programa para a Média de Idade
int IdadeMinima = 20;
int IdadeMaxima = 50;
int IdadeMedia = (IdadeMinima+IdadeMaxima)/2; 

Console.WriteLine($"A media de idade é {IdadeMedia} anos");

// =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

// EXERCÍCIO N2:
// ==> Euro para Real hoje (16/05/20222) = EUR 1,00 = BRL 5,27
int Qtnd_Euro = 750;
float Const_Conversor = 5.27f;
float ValorCompraReal = Qtnd_Euro * Const_Conversor;

Console.WriteLine($"{Qtnd_Euro} Euros equivale a R${ValorCompraReal}");

// =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

// EXERCÍCIO N3:
// ==> Comissão do vendedor de carros
int ValorVendaDeCarros = 500000;
int ComissaoVendas  = 5;
int ValorComissao = (ValorVendaDeCarros*ComissaoVendas)/100;

Console.WriteLine($"O valor da comissão recebida foi de R${ValorComissao}");

// =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

// EXERCÍCIO N4:
// ==> Conversor Celsius  para  Fahrenheit
Console.Write("Digite a temp em Cº: ");
float ValorCelsius = float.Parse(Console.ReadLine());
float ValorFahrenheit = (9*ValorCelsius+160)/5;
Console.WriteLine($"Cº{ValorCelsius} = Fº{ValorFahrenheit}");

// =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

// EXERCÍCIO N5:
// ==> Conversor Fahrenheit para Celsius
Console.Write("Digite a temp em Fº: ");
float ValorFahrenheit2 = float.Parse(Console.ReadLine());
float ValorCelsius2 = (ValorFahrenheit2-32)*5/9;
Console.WriteLine($"Fº{ValorFahrenheit2} = Cº{ValorCelsius2}");

// =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

// EXERCÍCIO N6:
// ==> Altura por peso ideal
Console.Write("Informe sua altura: "); // para trabalhar com int
float ValorAltura = float.Parse(Console.ReadLine());
float PesoIdeal = (72.7f * ValorAltura)-58;
Console.WriteLine($"Valor de peso ideal = {PesoIdeal}Kg");

// =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

// EXERCÍCIO N7:
// ==> Ler 4 notas de um aluno e imprimir a média
float nota1, nota2, nota3, nota4, MediaAluno;
Console.Write("Informe a 1ª nota: ");
nota1 = float.Parse(Console.ReadLine());
Console.Write("Informe a 2ª nota: ");
nota2 = float.Parse(Console.ReadLine());
Console.Write("Informe a 3ª nota: ");
nota3 = float.Parse(Console.ReadLine());
Console.Write("Informe a 4ª nota: ");
nota4 = float.Parse(Console.ReadLine());

MediaAluno = (nota1+nota2+nota3+nota4)/4;
Console.WriteLine($"Media do aluno = {MediaAluno}");
if(MediaAluno>7){
    Console.WriteLine("APROVADO!");
}else{
    Console.WriteLine("REPROVADO!");
}

// =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

// EXERCÍCIO N8:
// ==> Subtração entre A e B
int A, B, Sub;
Console.Write("Informe o valor de A: ");
A = int.Parse(Console.ReadLine());
Console.Write("Informe o valor de B: ");
B = int.Parse(Console.ReadLine());

Sub = A - B;
if(Sub<0){
    Console.WriteLine($"Valor negativo! = {Sub}");
}else if(Sub==0){
    Console.WriteLine($"Valor é Zero! = {Sub}");
}else{
    Console.WriteLine($"Valor positivo! = {Sub}");
}

// =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

// EXERCÍCIO N9:
// ==> Divisão de A por B
int A2, B2;
float Div2;
Console.Write("Informe o valor de A2: ");
A2 = int.Parse(Console.ReadLine());
Console.Write("Informe o valor de B2: ");
B2 = int.Parse(Console.ReadLine());

if(B2!=0){
    Div2=A2%B2;
    Console.WriteLine($"O resto da divisão de {A2} por {B2} é {Div2}!");
}else{
    Console.WriteLine("Error, divisões por 0 são inválidas!");
}

// =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

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
//float Const_Conversor = 5.27f; // é constante, então não muda
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