namespace ListaOrdonata
{
    class Program
    {
        static void Main(string[] args)
        {
            StructL L = new StructL();
            L.Push(5);
            L.Push(7);
            L.Push(3);
            L.Push(1);
            L.Push(6);
            L.Push(4);
            L.Push(2);
            L.Afisare();
        }
    }
}
