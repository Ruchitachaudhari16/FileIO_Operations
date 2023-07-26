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
        public void Copy_File()
        {
            string copyPath = @"C:\RFP288Batch\FileIOOperations\FileIO_Operations\FileOperationDemo\FileOperationDemo\Files\Abc.txt";
            File.Copy(path,copyPath);
            Console.WriteLine("File is copied");
            Console.WriteLine("-------------------------------------------------");
        }
        public void Delete_File()
        {
            string copyPath = @"C:\RFP288Batch\FileIOOperations\FileIO_Operations\FileOperationDemo\FileOperationDemo\Files\Abc.txt";
            File.Delete(copyPath);
            Console.WriteLine("File is Deleted");
            Console.WriteLine("--------------------------------------------------");

        }
        public void ReadFrom_StreamReader()
        {
            //stream Reader class is used to read string from a stream in a specified ending
            using (StreamReader sr = File.OpenText(path))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }
            Console.WriteLine("----------------------------------------------------");
        }
        public void WriteFrom_StreamWriter()
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Hey Hi...................");
                sw.Close();
                Console.WriteLine(File.ReadAllText(path));

            }
            Console.WriteLine("-------------------------------------------------------");
        }


    }
}
