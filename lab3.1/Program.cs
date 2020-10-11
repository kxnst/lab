using System;
using System.IO;
using lab3._1.Controller;
namespace lab3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            String Root = Directory.GetCurrentDirectory();

            Controller.Controller controller = new Controller.Controller();
        }
    }
}
