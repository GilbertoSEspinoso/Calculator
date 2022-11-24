namespace Calculator
{
    public class Soma
    {
        public void Somando()
        {
            var titulo = new Titulo();
            var menu = new Menu();
            double a, b, x;

            Console.Clear();
            titulo.MenuTitulo();
            Console.WriteLine("[Somando]");
            Console.Write(">>  ");
            a = double.Parse(Console.ReadLine());
            Console.Write(" +  ");
            b = double.Parse(Console.ReadLine());
            x = a + b;
            Console.Write(" =  {0}", x);
            Console.WriteLine("\n<< voltar");
            Console.ReadLine();
            menu.Options();
        }
    }
}