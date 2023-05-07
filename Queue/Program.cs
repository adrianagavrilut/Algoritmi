
namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Coada coada = new Coada();
            coada.Push(1);
            coada.Push(2);
            coada.Push(3);
            coada.View();
            coada.Pop();
            coada.View();
        }
    }
}
