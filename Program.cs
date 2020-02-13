using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SkyOneConsole
{
    class Program
    {
        private const string V = "Metodo A";

        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //var diasUteisDoMes = RetornarDiasUteis(2, 2020);

            //await Task.Run(TaskEscreverMetodoA());

            Teste();


            //var metodoA = await EscreverMetodoA();

            Console.ReadKey();
        }


        public static List<string> RetornarDiasUteis(int quantidadeMeses, int quantidadeAnos)
        {
            int mesSeguinte = quantidadeMeses + 1;

            List<string> diasUteis = new List<string>();

            DateTime Ano = new DateTime(quantidadeAnos,quantidadeMeses,1);


            while(Ano.Month < mesSeguinte)
            {
                if(Ano.DayOfWeek != DayOfWeek.Saturday || Ano.DayOfWeek != DayOfWeek.Sunday)
                {
                    diasUteis.Add(Ano.ToShortDateString());
                }

                Ano.AddDays(1);
            }

            return diasUteis;
        }




        public static void Teste()
        {
            Task.Run(() => {
                Console.WriteLine("Metodo A",
                     Thread.CurrentThread.ManagedThreadId);
            });
        }


        // Como ficou
        //public static async Action TaskEscreverMetodoA()
        //{
        //    await Task.Delay(2000);
        //    Console.WriteLine("Metodo A");
        //}

        public async Task TaskEscreverMetodoB()
        {
            await Task.Delay(2000);
            Console.WriteLine("Metodo B");
        }

        public async Task TaskEscreverMetodoC()
        {
            await Task.Delay(2000);
            Console.WriteLine("Metodo C");
        }

    }
}

/* 6 - Crie as seguintes rotinas
	a) Crie um método chamado MetodoA que escreve no console a informação “Metodo A”
	b) Crie um método chamado MetodoB que escreve no console a informação “Metodo B”
	c) Crie um método chamado MetodoC que escreve no console a informação “Metodo C”
	d) Execute os métodos A,B ao mesmo tempo, aguarde a finalização deles, e depois execute o método C
	e) Execute os métodos A,B,C ao mesmo, e após o término de cada método, escrever no console que o método em questão foi 


/* 10 - Criar um método que ao passar o mês e o ano como parâmetros, retorna uma lista contendo os dias úteis (abstrair função de feriados) */

/* 1 - Crie as classes contendo as seguintes informações

Pessoas
Codigo: numérico
Nome: texto
DataNascimento: data
Genero: {masculino, feminino, outros}

Pets:
Codigo: numérico
CodigoDono: númerico
Nome: texto
DataNascimento: data
tipo: {cachorro, gato, papagaio, outros} */
