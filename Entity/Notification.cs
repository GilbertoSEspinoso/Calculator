namespace Calculator.Entity
{
    public class Notification
    {
        public void TitleTop()
        {
            Console.Clear();
            Console.WriteLine("*********CALCULADORA*************");
            Console.WriteLine("*********************************");
            Console.WriteLine();
        }
        public void Warning()
        {
            var menu = new MenuMain();
            Console.WriteLine("  Opção Invalida! [Renicie >>>]");
            Console.ReadLine();
            menu.Menu();
        }
        public void Restart()
        {
            var menu = new MenuMain();
            Console.WriteLine("Operação Finalizada [Voltar <<<]");
            Console.ReadLine();
            menu.Menu();

        }
    }
}