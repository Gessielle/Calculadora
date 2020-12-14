using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double primeiron=0, segundon=0, result=0, n=0; // n = número
            string op, vlusuario; // op = operação
            bool vlvalido=false; // vl = valor
        
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("         ***** CALCULADORA  ***** ");
            Console.ResetColor();

            Console.Write("\n");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("********** TECLE ENTER PARA VISUALIZAR O MENU **********");
            Console.ReadKey();
            Console.ResetColor();

            string tecla = "";
            while(tecla != ".")

            {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("       DIGITE A OPERAÇÃO DESEJADA E TECLE ENTER: \n (+) (-) (*) (/) (%) [1 (exponenciação)] [2 (raiz quadrada)] [3 (créditos)] [4 (finalizar)]: ");
            op = Console.ReadLine();
            Console.ResetColor();

            switch (op)

            {
            case "2":
            double valor, result1;

            Console.Write("digite o valor: ");
            valor = Convert.ToDouble(Console.ReadLine());
            result1 = Math.Sqrt(valor);
            Console.WriteLine($"= {result1}");
            Console.WriteLine("TECLE ENTER PARA SAIR E EXECUTAR O PROGRAMA NOVAMENTE: ");
            Console.ReadKey();
            Environment.Exit(-1);
            break;

            case "3":
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Programa desenvolvido por Gessielle Barossi, aluna da Etec Adolpho Berezin ");
            Console.WriteLine("instruída pelos professores Ermogenes Palacio e Diego Neri, no Curso Técnico de informática.");
            Console.WriteLine("Link do Repositorio: https://github.com/Gessielle/Calculadora ");
            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Tecle Enter para sair e executar o programa novamente! ");
            Console.ReadKey();
            Environment.Exit(-1);
            Console.ResetColor();
            break;

            case "4":
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("OBRIGADA(O) POR UTILIZAR O PROGRAMA! \n TECLE ENTER PARA SAIR!");
            Console.ResetColor();
            Console.ReadKey();
            Environment.Exit(0);
            break;
            }

            Console.Write("Digite o primeiro número e tecle Enter:  ");
            vlusuario = Console.ReadLine();
            vlvalido = double.TryParse(vlusuario, out n);

            if (vlvalido)

            {
            primeiron = Math.Round(double.Parse(vlusuario), 5);
            }
           
            else

            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("NÚMERO INVÁLIDO. ");
            Console.ResetColor();
            Console.WriteLine($" TECLE ENTER PARA FINALIZAR OU VOLTAR AO MENU: ");
            Console.ReadKey();
            Environment.Exit(-1);
            }

            Console.Write("Digite o segundo número: ");
            vlusuario = Console.ReadLine();
     
            if (vlvalido)

            {
            segundon = Math.Round(double.Parse(vlusuario), 5);
            }
            
            else

            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NÚMERO INVÁLIDO. ");
            Console.ResetColor();
            Console.WriteLine($" Tecle Enter: ");
            Console.ReadKey();
            Environment.Exit(-1);
            }

            switch (op)

            {
            case "+":
            result = primeiron + segundon;
            Console.WriteLine($"{primeiron} + {segundon} = {result}\n");
            break;

            case "-":
            result = primeiron - segundon ;
            Console.WriteLine($"{primeiron} - {segundon} = {result}\n");
            break;

            case "*":
            result = primeiron * segundon ;
            Console.WriteLine($"{primeiron} * {segundon} = {result}\n");
            break;

            case "/":
            result = primeiron / segundon ;
            Console.WriteLine($"{primeiron} / {segundon} = {result}\n");
            break;

            case "%":
            result = (primeiron * segundon) / 100 ;
            Console.WriteLine($"{primeiron} % {segundon} = {result}\n");
            break;

            case "1":
            result = Math.Pow(primeiron, segundon) ;
            Console.WriteLine($"{primeiron} ^ {segundon} = {result}\n");
            break;

            default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"OPERAÇÃO INVÁLIDA ");
            Console.ResetColor();
            Console.WriteLine($" TECLE ENTER E EXECUTE O PROGRAMA NOVAMENTE ");
            Console.ReadKey();
            Environment.Exit(-1);
            break;
            }  
            
            Console.WriteLine(" TECLE ENTER PARA SAIR OU RETORNAR AO MENU: ");
            tecla = Console.ReadLine();  
             
            }
             
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("OBRIGAGO(A) POR UTILIZAR O PROGRAMA! \n TECLE ENTER PARA FINALIZAR! ");
            Console.ResetColor();
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
