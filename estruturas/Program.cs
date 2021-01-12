using System;

namespace estruturas
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Pilha();
            var f = new Fila();

            p.push(1);
            p.push(2);
            p.push(3);

            Console.WriteLine(p.pull());
            Console.WriteLine(p.pull());
            Console.WriteLine(p.pull());

            f.push(1);
            f.push(2);
            f.push(3);

            Console.WriteLine(f.pull());
            Console.WriteLine(f.pull());
            Console.WriteLine(f.pull());
        }
    }
}
