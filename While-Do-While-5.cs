using System;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0;

        Console.Write("Digite um número inteiro (ou um número negativo para sair): ");
        int número = int.Parse(Console.ReadLine());

        while(número >= 0)
        {
            soma += número;
            Console.Write("Digite outro número inteiro ( ou um número negativo para sair):");
            número = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(" A soma dos números é : " + soma);
    }
}
