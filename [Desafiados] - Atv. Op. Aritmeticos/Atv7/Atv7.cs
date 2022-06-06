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
