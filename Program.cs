//Console.WriteLine("Olá, mundo!");

/**
1. Tipos de variáveis var, int, short, long, decimal, double, bool e string;
*/

int a = 10;
int b = 5;
long c = 100;
float f = 10.50f;
double e = 10.5;

var x = 100;
x = 99;
//x = "Texto";
//string str = "Texto qualquer";
var str = "Texto qualquer";

//Console.WriteLine(str);
//Console.WriteLine("Valor " + x);
//Console.WriteLine($"Valor {x}");

/**
2. Operadores de atribuição, aritméticos, relacionais, lógicos e unários;
*/
int r = a + b;
//Console.WriteLine("Resultado " + r);

Console.WriteLine("Informe a 1a nota:");
var nota1 = Console.ReadLine();
Console.WriteLine("Informe a 2a nota:");
var nota2 = Console.ReadLine();

Console.WriteLine($"Nota 1: {nota1}");
Console.WriteLine($"Nota 2: {nota2}");

double media = (Convert.ToDouble(nota1) + Convert.ToDouble(nota2))/2;

Console.WriteLine($"Resultado: {media}");
if (media >= 6){
  Console.WriteLine("Aprovado");
} else {
  Console.WriteLine("Reprovado");
}



/**
3. Estruturas de decisão if/else, ternárias e switch;
4. Estruturas de repetição while, do/while, for, foreach;
5. Arrays e List.
*/


