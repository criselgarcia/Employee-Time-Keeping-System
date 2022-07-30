using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File_Stream;
using UI_Validation;


namespace Employee
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            string userInput = UI_and_Validation.Menu();

            switch (userInput)
            {
                case "TI":
                    UI_and_Validation.CompanyName_Validation();//class.method
                    File_Stream_TKS.inTimeFileStream();//class.method
                    UI_and_Validation.Details();
                    break;

                case "TO":
                    UI_and_Validation.CompanyName_Validation();//class.method
                    File_Stream_TKS.outTimeFileStream();//class.method
                    UI_and_Validation.Details();
                    break;

                case "1":
                    File_Stream_TKS.ReadTextinFile();
                    break;
                case "2":
                    File_Stream_TKS.inTimeUpdateText();
                    break;
                case "3":
                    File_Stream_TKS.outTimeUpdateText();
                    break;
                case "4":
                    File_Stream_TKS.DeleteFile();
                    break; 
                case "5":
                    File_Stream_TKS.ClearTextinFile();
                    break;
                default:
                    break;
            }

        }



    }
}