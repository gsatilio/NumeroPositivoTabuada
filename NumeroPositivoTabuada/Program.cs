//faça um programa que leia um numero inteiro positivo e imprima a sua tabuada

int numero, tabuada, aux;

Console.WriteLine("Informe um numero inteiro positivo:");
numero = int.Parse(Console.ReadLine());
if (numero > 0){ 
    for (tabuada = 1; tabuada <= 10; tabuada++)
    {
        aux = (numero * tabuada);
        Console.WriteLine(numero + " x " + tabuada + " eh " + aux);
    }
} else
{
    Console.WriteLine("O numero nao eh positivo!");
}

Console.ReadKey();

// teste 111