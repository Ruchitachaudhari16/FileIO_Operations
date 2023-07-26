using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperationDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileOperations fileOperations = new FileOperations();

            while (true)
            {
                Console.WriteLine("1:File Exist or not");
                Console.WriteLine("Choose the option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        fileOperations.File_Exist();
                        break;

                }
            }
        }
    }
}
