using System;

class Program
{
    static void Main(string[] args)
    {
        string senhaCorreta = "1234";
        int tentativas = 0;
        bool acertou = false;

        do
        {
            Console.Write("Digite a senha: ");
            string senhaDigitada = Console.ReadLine();
            tentativas++;

            if (senhaDigitada == senhaCorreta)
            {
                acertou = true;
                Console.WriteLine("Senha correta!! Acesso concebido.");
            }
            else
            {
                if (tentativas < 3)
                {
                    Console.WriteLine("Senha incorreta. Tente Novamente (" + (3 - tentativas) + " tentativas(s) restantes(s)).");
                }
            }
        } while (!acertou && tentativas < 3);

        if (!acertou)
        {
            Console.WriteLine("Número maximo de tentativas atingido. Acesso bloqueado.");
        }
    }
}

                    
                    
                
                
               


