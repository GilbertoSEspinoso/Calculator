using System.Globalization;

namespace Calculator.Entity
{
    public class MenuMain : Notification
    {
        public void Menu()
        {
            TitleTop();
            Console.Write("Digite o número: ");
            double nX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Clear();
            TitleTop();
            Console.Write("escolha [+] [-] [*] [/] ");
            char opt = char.Parse(Console.ReadLine());

            if (opt == '+' || opt == '-' || opt == '*' || opt == '/')
            {
                Console.Clear();
                TitleTop();
                Console.Write($"{nX} {opt} Digite o número:  ");
                double nY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                var operation = new BasicOperations();
                switch (opt)
                {
                    case '+': operation.Addition(nX, nY); break;
                    case '-': operation.Subtraction(nX, nY); break;
                    case '*': operation.Multiplication(nX, nY); break;
                    case '/': operation.Division(nX, nY); break;
                }
            }
            else
            {
                Warning();
            }
        }
    }
}