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
