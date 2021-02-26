using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld6
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            // estrutura de repetição; Funciona semelhante ao if e tbm tem q por uma condição entre ():
            while(contador < 5) // enquanto for verdade faça:
            {
                Console.WriteLine("rodando while " + contador);
                contador = contador + 1; // ou pode-se usar: contador += 1 ou contador++
            }

            // do while, a mesma coisa do while mas executa o codigo ao menos uma vez mesmo que a condição for falsa
            do
            {
                Console.WriteLine("executando do while");
            } while (1000 < 10);
            Console.WriteLine("");


            //foreach, estrutura de repetição para percorrer vetores, mas não existem em todas as linguagens´:
            string[] nomes = { "Jorge", "Davi", "Ana", "JotaP", "Will", "Yodao" };
            int n = 0;
            foreach (string nome in nomes) // para cada nome no array nomes repita o bloco de codigo (nesse caso 5x pq tem 5 nomes)
            {
                Console.WriteLine(nome); // vai salvar e exucutar item por item do array criado, que nesse caso é nomes[]
                Console.WriteLine("funcionando foreach " + nomes[n]);
                n++;
            }
            Console.WriteLine("");


            //for(declarar o contador;condição; contador++):
            for (int cont = 0; cont < nomes.Length; cont++) //Lenght - comprimento, dessa forma não precisa contar manualmente e usa a quantidade da variavel onde Length foi aplicada
            {
                Console.Write("for funcionando " + cont + " ");
                Console.WriteLine(nomes[cont]); // outra forma de usar array, mas com for
            }

            for (int cont2 = nomes.Length-1; cont2 >= 0; cont2--) // usar for de forma decrescente, Lenght retorna o comprimento total do array que no caso é 7 (0 a 6), entao coloca -1 pra ajustar
            {
                Console.Write(cont2 + " ");
                Console.WriteLine(nomes[cont2]);
            }


            Console.ReadLine();
        }
    }
}
