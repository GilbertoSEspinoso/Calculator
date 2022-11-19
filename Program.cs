namespace Calculator
{
    class Program
    {
        static public void TitleTop()
        {
            Console.Clear();
            Console.WriteLine("************CALCULADORA****************");
            Console.WriteLine("***************************************");
        }
        static void Main(string[] Args)
        {
            Menu();
        }
        public static void Menu()
        {
            TitleTop();
            Console.Write("Digite o primeiro Valor => : ");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            TitleTop();
            Console.WriteLine("Escolha a função  :\n1[+] 2[-] 3[x] 4[÷]");
            short option = Convert.ToInt16(Console.ReadLine());
            TitleTop();
            Console.Write("_Digite o segundo valor => : ");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            switch (option)
            {
                case 1:
                    TitleTop();
                    Console.WriteLine("Resultado de {0} + {1} = {2}", valor1, valor2, valor1 + valor2);
                    break;
                case 2:
                    TitleTop();
                    Console.WriteLine("Resultado de {0} - {1} = {2}", valor1, valor2, valor1 - valor2);
                    break;
                case 3:
                    TitleTop();
                    Console.WriteLine("Resultado de {0} x {1} = {2:F2}", valor1, valor2, valor1 * valor2);
                    break;
                case 4:
                    TitleTop();
                    Console.WriteLine("Resultado de {0} / {1} = {2:F2}", valor1, valor2, valor1 / valor2);
                    break;
                default: Menu(); break;
            }
            Console.WriteLine("_______________________\n_______________________");
            Console.WriteLine("Pressione [esc] para sair\nou quaquer tecla para continuar.");
            if (Console.ReadKey().Key == ConsoleKey.Escape)
                System.Environment.Exit(0);
            else
                Menu();
        }

    }
}
