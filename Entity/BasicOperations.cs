namespace Calculator.Entity
{
    public class BasicOperations : MenuMain
    {
        public double Nx { get; private set; }
        public double Ny { get; private set; }

        public BasicOperations()
        {
        }
        public BasicOperations(double nX, double nY)
        {
            Nx = nX;
            Ny = nY;
        }

        public void Addition(double nX, double nY)
        {
            double result = nX + nY;
            Console.Clear();
            Console.WriteLine($"[RESULTADO] {nX} + {nY} = {result}");
            Restart();
        }
        public void Subtraction(double nX, double nY)
        {
            double result = nX - nY;
            Console.Clear();
            TitleTop();
            Console.WriteLine($"[RESULTADO] {nX} - {nY} = {result}");
            Restart();
        }
        public void Multiplication(double nX, double nY)
        {
            double result = nX * nY;
            Console.Clear();
            TitleTop();
            Console.WriteLine($"[RESULTADO] {nX} x {nY} = {result}");
            Restart();
        }
        public void Division(double nX, double nY)
        {
            double result = nX / nY;
            Console.Clear();
            TitleTop();
            Console.WriteLine($"[RESULTADO] {nX} : {nY} = {result}");
            Restart();
        }
    }
}