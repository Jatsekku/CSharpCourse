

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = args[0];
            System.Console.WriteLine("Hello!, " + name);

            //foreach (var item in args)
            //{
            //    System.Console.WriteLine("Hello, " + item);
            //}
        }
    }
}
