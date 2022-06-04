using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
             ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(11111, 111111111);

              lista.Adicionar(contaDoGui);

              lista.Adicionar(new ContaCorrente(874, 5679787));
              lista.Adicionar(new ContaCorrente(874, 5679754));
              lista.Adicionar(new ContaCorrente(874, 5679445));
              lista.Adicionar(new ContaCorrente(874, 5679446));
              lista.Adicionar(new ContaCorrente(874, 5679447));
              lista.Adicionar(new ContaCorrente(874, 5679448));
              lista.Adicionar(new ContaCorrente(874, 5679449));
              lista.Adicionar(new ContaCorrente(874, 5679450));
              lista.Adicionar(new ContaCorrente(874, 5679451));
              lista.Adicionar(new ContaCorrente(874, 5679452));
              lista.Adicionar(new ContaCorrente(874, 5679453));

              lista.EscreverListaNaTela();

              lista.Remover(contaDoGui);

            Console.WriteLine("Após remover o item");

              lista.EscreverListaNaTela();

            Console.ReadLine();
        }
        
    
        static void TestaArrayDeContaCorrente()
        {
             ContaCorrente[] contas = new ContaCorrente[]
             {
                 new ContaCorrente(874, 5679787),
                 new ContaCorrente(874, 4456668),
                 new ContaCorrente(874, 7781438)

             };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }


        }
        static void TestaArrayInt()
        {
            int[] idades = null;
            idades = new int[6];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;
            idades[5] = 60;

            Console.WriteLine(idades.Length);


            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");


        }
    }
}
