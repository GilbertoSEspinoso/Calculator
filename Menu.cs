using System;

namespace Calculator
{
    public class Menu
    {
        public void Options()
        {
            var titulo = new Titulo();
            var somar = new Soma();
            var diminuir = new Subtracao();
            var multiplicar = new Multiplicacao();
            var dividir = new Divisao();

            titulo.MenuTitulo();
            Console.WriteLine("[1] p/ SOMAR");
            Console.WriteLine("[2] p/ SUBTRAIR");
            Console.WriteLine("[3] p/ MULTIPLICAR");
            Console.WriteLine("[4] p/ DIVIDIR");
            Console.WriteLine("[0] FECHAR O PROGRAMA");
            short option = Int16.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    somar.Somando();
                    break;
                case 2:
                    diminuir.Subtraindo();
                    break;
                case 3:
                    multiplicar.Multiplicando();
                    break;
                case 4:
                    dividir.Dividindo();
                    break;
                case 0:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção Invalida!");
                    Console.Write("<<voltar");
                    Console.ReadLine();
                    Options();
                    break;
            }
        }
    }
}