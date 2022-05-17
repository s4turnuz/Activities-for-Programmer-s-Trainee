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
