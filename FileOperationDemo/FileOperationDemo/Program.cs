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
                Console.WriteLine("2:Read All Lines from file");
                Console.WriteLine("3:Read All Text from file");
                Console.WriteLine("4:Copy file");
                Console.WriteLine("5:Delete file");
                Console.WriteLine("Choose the option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        fileOperations.File_Exist();
                        break;

                        case 2:
                        fileOperations.ReadAll_Lines();
                        break;

                        case 3:
                        fileOperations.ReadAll_Text();
                        break;

                        case 4:
                        fileOperations.Copy_File();
                        break;
                        case 5:
                        fileOperations.Delete_File();
                        break;

                }
            }
        }
    }
}
