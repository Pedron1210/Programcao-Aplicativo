internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Calculadora Basica");

        Console.Write("Escreva o 1 número: ");
        double num1 = double.Parse(Console.ReadLine());
        
        Console.Write("escreva o 2 número: ");
        double num2 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Operações disponiveis");
        Console.WriteLine("* - Sultiplicação");
        Console.WriteLine("/ - Divisão");
        Console.WriteLine("+ - Adição");
        Console.WriteLine("- - Subtração");

        Console.WriteLine("Escolha a operação: ");
        char operacao = char.Parse(Console.ReadLine());

        if (operacao == '*')
        {
            Console.WriteLine(num1 + " " + operacao + " " + num2 + " = " +num1 *  num2);
        }
        else if(operacao == '/')
        {
            if (num2 == 0)
            {
                Console.WriteLine("Não poder ser dividido por zero ");
            }
            else
            {
            Console.WriteLine(num1 + " " + operacao + " " + num2 + " = " +num1 / num2);
            }
        }
        else if(operacao == '+')
        {
            Console.WriteLine(num1 + " " + operacao + " " + num2 + " = " + (num1 + num2));
        }
        else if(operacao == '-')
        {
            Console.WriteLine(num1 + " " + operacao + " " + num2 + " = " + (num1 - num2));
        }
        else
        {
            Console.WriteLine("essa operação não existe");
        }

        Console.ReadKey(); 
    }
}