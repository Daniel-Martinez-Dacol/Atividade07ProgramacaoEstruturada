using System;

/**
 
Conteúdo: Revisão de Arrays, Criação de Métodos e Pesquisa sobre Modificadores de Parâmetros.

-Desenvolver um algoritmo que dados 10 valores inteiros permita:

• Encontrar o Maior Valor da sequência
• Encontrar o Menor Valor da sequência
• Encontrar o Valor Médio da sequência
• Encontrar os 3 maiores valores da sequência
• Encontrar os valores negativos da sequência
• Mostrar na Tela os valores da sequência
• Remover um item da sequência

-Critérios de Aceite:

• Para obter o Maior valor utilize o modificador de parâmetro: ref
• Para obter o Menor valor utilize o modificador de parâmetro: out

 */
namespace Atividade07ProgramacaoEstruturada.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicia o Array pra armazenar 10 numeros inteiros.

            int[] numeros = new int[10];

            int maiorNumero = numeros[0];
            int menorNumero;
            int soma = 0;


            //Recebe os numeros inputado pelo usuario e salva no array.
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º numero:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            //maior numero:

            MaiorNumero(numeros, ref maiorNumero);

            //menor valor:

            MenorNumero(numeros, out menorNumero);

            //valor medio:
            ValorMedio(numeros, soma);

            // 3 maiores valores:
            maiores3Numeros(numeros, maiorNumero);

            //Valores negativos: 
            NumerosNegativos(numeros);

            //Mostrar valores na sequencia: 
            ValoresNaSequencia(numeros);

            //Remover item:
            RemoverItem(numeros);

            Console.ReadLine();


        }

        //Metodo para o maior valor:
        static void MaiorNumero(int[] numeros, ref int maiorNumero)
        {

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maiorNumero)
                    maiorNumero = numeros[i];
            }
            Console.WriteLine($"\n-O maior numero é: {maiorNumero}");

        }

        //Metodo para o menor valor:
        static void MenorNumero(int[] numeros, out int menorNumero)
        {
            menorNumero = numeros[0];
            for (int i = 0; i < numeros.Length; i++)
            {
                if (menorNumero > numeros[i])
                    menorNumero = numeros[i];
            }
            Console.WriteLine($"\n-O menor numero é: {menorNumero}");

        }

        //Metodo para o valor médio:
        static int ValorMedio(int[] numeros, int soma)
        {
            int valorMedio = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
                valorMedio = soma / numeros.Length;

            }
            Console.WriteLine($"\n-O valor médio é: {valorMedio}");
            return soma;
        }

        //Metodo para os maiores 3 numeros:
        static int maiores3Numeros(int[] numeros, int maiorNumero)
        {
            int maiorNumero2 = numeros[0];
            int maiorNumero3 = numeros[0];
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maiorNumero)
                    maiorNumero = numeros[i]; //10 

                if (numeros[i] > maiorNumero2 && numeros[i] != maiorNumero)
                    maiorNumero2 = numeros[i];//9

                if (numeros[i] != maiorNumero && numeros[i] != maiorNumero2 && numeros[i] > maiorNumero3)
                    maiorNumero3 = numeros[i];


            }
            Console.WriteLine($"\n-Os 3 maiores numeros são: {maiorNumero}, {maiorNumero2} e {maiorNumero3}");
            return maiorNumero;
        }

        //Metodo para os valores negativos:
        static void NumerosNegativos(int[] numeros)
        {
            string numerosNegativos = "";
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    numerosNegativos += numeros.GetValue(i) + " ";
                }
            }
            Console.WriteLine($"\n-Os numeros negativos são: {numerosNegativos}");
        }

        //Metodo pra mostrar os valors em sequencia:
        static void ValoresNaSequencia(int[] numeros)
        {
            string listaDosNumeros = "";
            for (int i = 0; i < numeros.Length; i++)
            {
                listaDosNumeros += numeros.GetValue(i) + " ";

            }
            Console.WriteLine($"\n-Valores da Sequencia: {listaDosNumeros}");
        }

        //Metodo pra remover item da sequencia: 
        static void RemoverItem(int[] numeros)
        {
            int[] novaLista = new int[numeros.Length - 1];

            Console.Write("\nDigite a posição do numero a ser removido: ");
            int posicaoDoNumeroRemovido = int.Parse(Console.ReadLine());

            string novaListaComNumeroRemovido = "";

            for (int i = 0; i < novaLista.Length; i++)
            {
                if (numeros[i] != numeros[posicaoDoNumeroRemovido - 1])
                {
                    novaLista[i] = numeros[i];
                    novaListaComNumeroRemovido += novaLista[i] + " ";
                }
            }
            Console.WriteLine($"\nSequencia com numero removido: {novaListaComNumeroRemovido}");
        }
    }
}
