﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperationDemo
{       
    //File IO is used to perform numerous operations with files such reading,writing,creating and deleting.

    public class FileOperations
    {
        string path = @"C:\\RFP288Batch\\FileIOOperations\\FileIO_Operations\\FileOperationDemo\\FileOperationDemo\\Files\\Ruchita.txt";

        public void File_Exist()
        {
            if (File.Exists(path))
            {
                Console.WriteLine("File exists");
            }
            else { Console.WriteLine("File is not exists"); }
        }
       
      
       
       
    }
}