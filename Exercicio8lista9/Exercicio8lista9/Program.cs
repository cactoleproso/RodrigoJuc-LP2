using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8lista9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double salariomin; double wtusados; int tipocons; double valorwt; double valorpago; double faturamento;  //variáveis a serem utilizadas
            bool repetir = true;  // repetição ( caso a resposta final for "sim" o programa precisa ser executado novamente )
            faturamento = 0;
            valorpago = 0;
            int contador = 0; //impedir erro
            while(repetir == true)
            {
                Console.Clear(); //limpar o console toda vez que 
                
                Console.WriteLine("Digite o salário mínimo atual; a quantidade de quilowatts usados e em seguida o tipo de consumidor: ");
                salariomin = Convert.ToDouble(Console.ReadLine());        //coletando dados de uma só vez
                wtusados = Convert.ToDouble(Console.ReadLine());
                tipocons = int.Parse(Console.ReadLine());

                valorwt = salariomin / 8;
                if (tipocons == 1)
                {
                    valorpago = (valorwt * wtusados) * 5 / 100;  // conta base + valores pro cálculo do valor a ser pago pelo consumidor
                }
                else if (tipocons == 2)
                {
                    valorpago = (valorwt * wtusados) * 10 / 100;

                }
                else if (tipocons == 3)
                {
                    valorpago = (valorwt * wtusados) * 15 / 100;
                }
                Console.WriteLine("O consumidor deve pagar R${0}" , valorpago); //exibir valor pago
                Console.WriteLine("O valor de cada quilowatt é R${0}", valorwt); //exibir valor de quilowatt
                faturamento = faturamento + valorpago; // calcular o faturamento da empresa ( começar uma nova operação não reiniciar isto ) 
                //agora, a quantidade de pessoas que pagam entre 500 e 1000 reais
                if(valorpago >= 500 && valorpago <= 1000)
                {
                    contador++;
                }
                Console.WriteLine("Você gostaria de calcular os valores de outro consumidor? ('Sim' para continuar )"); //esta parte do programa irá dizer se deverá repetir ou não 
                string resposta = Console.ReadLine();
                if (resposta == "Sim")
                {
                }
                else
                    repetir = false;
            }
            Console.WriteLine("Atualmente {0} pessoas pagaram entre 500 e 1000 reais", contador); //exibir contagem de pessoas que pagaram de 500 até 100 reais
            Console.WriteLine("Faturamento atual da empresa: {0} reais", faturamento); //exibir faturamento da empresa     
            Console.ReadLine();
        }
    }
}
