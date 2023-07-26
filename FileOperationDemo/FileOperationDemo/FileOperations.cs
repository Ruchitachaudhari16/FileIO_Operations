using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FileOperationDemo
{       
    //File IO is used to perform numerous operations with files such reading,writing,creating and deleting.

    public class FileOperations
    {
        string path = @"C:\RFP288Batch\FileIOOperations\FileIO_Operations\FileOperationDemo\FileOperationDemo\Files\Ruchita.txt";
        

        public void File_Exist()
        {
            if (File.Exists(path))
            {
                Console.WriteLine("File exists");
            }
            else
            { Console.WriteLine("File is not exists");}
            Console.WriteLine("-----------------------------------------------");
        }
        
        public void ReadAll_Lines()
        {
            //Read all lines is used to open a text file then it will read all the lines in to a string Array.
            //and then close the file.
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("----------------------------------------------");
        }
        public void ReadAll_Text()
        {//ReadAllText- used to open text file then it will read all the lines at a time with out help of array.
            string lines = File.ReadAllText(path);
            {
                Console.WriteLine(lines);
            }
            Console.WriteLine("-----------------------------------------------");
        }


    }
}
