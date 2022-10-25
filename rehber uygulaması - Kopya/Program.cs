using System;

namespace vscode_deneme
{
    public class Program
    {
        public static void Main()
        {   
            
            MainBlock ana = new MainBlock();
            ana.MainBlockF();
        }

        public void ProgramKapat()
        {
            Console.WriteLine();
            Console.WriteLine("Program kapanıyor...");
        }
    }
}
