/*

// ===== TESTE DE CONDICIONAIS ======

int a = 10;
int b = 20;

Console.WriteLine($"[a] é igual a [b]? {a == b}");
Console.WriteLine($"[a] é diferente de [b]? {a != b}");
Console.WriteLine($"[a] é maior q [b]? {a > b}");
Console.WriteLine($"[a] é menor que [b]? {a < b}");
Console.WriteLine($"[a] é maior ou igual q [b]? {a >= b}");
Console.WriteLine($"[a] é menor ou igual q [b]? {a <= b}");

Console.WriteLine($"teste de [a] com [b] {a > b && b > a}");*/

/*
 
// ===== ATV DE HABILITAÇÃO =====

int idade;
Console.Write("Informe seu idade: ");
idade = int.Parse(Console.ReadLine());

if(idade >= 18)
{
    Console.WriteLine($"Você pode tirar habilitação, pois tem {idade} anos.");
    Console.WriteLine($"Condição-Idade/Permissão = {idade >= 18}");
}
else
{
    Console.WriteLine($"Você não pode tirar habilitação, pois tem {idade} anos.");
    Console.WriteLine($"Condição-Idade/Permissão = {idade >= 18}");
}*/

/*
 
// ===== ATV HABILITAÇÃO MAIS TRABALHADA =====

int idade, cont=0;
Console.Write("Informe sua idade:");
idade = int.Parse(Console.ReadLine());

if(idade < 18)
{
    Console.WriteLine($"Você ainda não pode dirigir, pois tem {idade} anos");
    while (idade != 18)
    {
        cont++;
        idade++;
    }
    Console.WriteLine($"Você pode dirigir daqui {cont} anos!");
}
else
{
    Console.WriteLine($"Você pode dirigir, pois tem {idade} anos.");
}*/



// ===== ATV DE CONDIÇÕES DAS NOTAS =====

int qutNota, i;
float media = 0;
Console.Write("Informe a quantidade de notas para atribuir a média: ");
qutNota = int.Parse(Console.ReadLine());

float[] notas = new float[qutNota];
for (i = 0; i < notas.Length; i++)
{
    Console.Write($"Informe a {i+1}ª nota: ");
    notas[i] = float.Parse(Console.ReadLine());
    media = media + notas[i];
}
media = media / i;

Console.WriteLine(media);

// condições com if
if(media > 7)
{
    Console.WriteLine("Aluno aprovado!");
}
else if(media < 5)
{
    Console.WriteLine("Aluno reprovado!");
}else if(media >= 5 && media < 7)
{
    Console.WriteLine("Aluno em recuperação!");
}

// condições com ternário
Console.WriteLine($"{(media > 7 ? "Aluno aprovado!" : "Aluno reprovado!")}"); // só duas condições :/