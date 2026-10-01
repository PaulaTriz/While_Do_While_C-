using System;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0;
        int numero;

        do
        {
            Console.Write("Digite um número inteiro (ou um número negativo para sair): ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                soma += numero;
            }
        } while (numero >= 0);

        Console.WriteLine("A soma dos números positivos digitados é: " + soma);
    }
}
