namespace Calculator
{
    public class Multiplicacao
    {
        public void Multiplicando()
        {
            var titulo = new Titulo();
            var menu = new Menu();
            double a, b, x;

            Console.Clear();
            titulo.MenuTitulo();
            Console.WriteLine("[Multiplicando]");
            Console.Write(">>  ");
            a = double.Parse(Console.ReadLine());
            Console.Write(" x  ");
            b = double.Parse(Console.ReadLine());
            x = a * b;
            Console.Write(" =  {0}", x);
            Console.WriteLine("\n<< voltar");
            Console.ReadLine();
            menu.Options();
        }
    }
}