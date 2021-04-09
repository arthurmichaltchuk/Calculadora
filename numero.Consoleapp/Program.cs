using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero.Consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            double primeiroNumero, segundoNumero;
            double resultado = 0;
            string opcao = "";
            int historico = 0;
            string histprimeironumero = null;
            string histsegundonumero = null;
            string histsinal = null;
            string histresultado = null;
            string[] hist = new string[100];
            
            do
            {
                Console.Clear();
                Console.WriteLine("...Calculadora 1.0...");
                Console.WriteLine("1. Para somar........");
                Console.WriteLine("2. Para subtrair.....");
                Console.WriteLine("3. Para multiplicar..");
                Console.WriteLine("4. Para dividir......");
                Console.WriteLine("5. Para ver histórico");
                Console.WriteLine("6. Para sair.........");
                opcao = Console.ReadLine();

 

                switch (opcao)
                {
                    case "1":
                        entrada(out primeiroNumero, out segundoNumero);
                        resultado = primeiroNumero + segundoNumero;
                        Console.Write("O resultado é: ");
                        Console.WriteLine(resultado);
                        Console.ReadLine();
                        histprimeironumero = Convert.ToString(primeiroNumero);
                        histsegundonumero = Convert.ToString(segundoNumero);
                        histresultado = Convert.ToString(resultado);
                        histsinal = "+";
                        historico++;
                        break;
                    case "2":
                        entrada(out primeiroNumero, out segundoNumero);
                        resultado = primeiroNumero - segundoNumero;
                        Console.Write("O resultado é: ");
                        Console.WriteLine(resultado);
                        Console.ReadLine();
                        histprimeironumero = Convert.ToString(primeiroNumero);
                        histsegundonumero = Convert.ToString(segundoNumero);
                        histresultado = Convert.ToString(resultado);
                        histsinal = "-";
                        historico++;
                        break;
                    case "3":
                        entrada(out primeiroNumero, out segundoNumero);
                        resultado = primeiroNumero * segundoNumero;
                        Console.Write("O resultado é: ");
                        Console.WriteLine(resultado);
                        Console.ReadLine();
                        histprimeironumero = Convert.ToString(primeiroNumero);
                        histsegundonumero = Convert.ToString(segundoNumero);
                        histresultado = Convert.ToString(resultado);
                        histsinal = "*";
                        historico++;
                        break;
                    case "4":
                        entrada(out primeiroNumero, out segundoNumero);
                        if (segundoNumero == 0)
                        {
                            Console.Write("Segundo número inválido! Tente novamente");
                            Console.ReadLine();          
                            break;
                        }
                        resultado = primeiroNumero / segundoNumero;
                        Console.Write("O resultado é: ");
                        Console.WriteLine(resultado);
                        Console.ReadLine();
                        histprimeironumero = Convert.ToString(primeiroNumero);
                        histsegundonumero = Convert.ToString(segundoNumero);
                        histresultado = Convert.ToString(resultado);
                        histsinal = "/";
                        historico++;
                        break;
                    case "5":
                        Console.WriteLine("...Histórico..."); 
                        for (int i = 0; i <= historico; i++)
                        {
                        
                        Console.WriteLine(hist[i]);                       
                        }
                        Console.ReadLine();

                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente");
                        break;

                }

                hist[historico] = histprimeironumero + " " + histsinal + " " + histsegundonumero + " = " + histresultado;
            } while (opcao != "6");

        }

        private static void entrada(out double primeiroNumero, out double segundoNumero)
        {
            Console.Write("Digite o primeiro número: ");
            primeiroNumero = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            segundoNumero = Convert.ToDouble(Console.ReadLine());
        }
    }
}
