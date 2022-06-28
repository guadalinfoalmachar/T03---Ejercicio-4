namespace T03_Eje4
{
    class T03_Eje4
    {
        static void Main()
        {
            int N = 4;

            Console.WriteLine("Valor inicial de N = {0}", N);
            Console.WriteLine("N + 77 = {0}", N += 77);
            Console.WriteLine("N - 3 = {0}", N -= 3);
            Console.WriteLine("N * 2 = {0}", N * 2);


            Console.WriteLine("Pulse cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}