using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TriangleTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //путь
            string inputpath = "D:\\SolutionsForSpaceApp\\2019\\input.txt";
            string outputpath = "D:\\SolutionsForSpaceApp\\2019\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();

            //номер книги
            int a;
            using (var reader = new StreamReader(inputpath))
            {
                a = Convert.ToInt32(reader.ReadLine());  // записываем в переменную
            }
            int k = 1;
            for (int i = 0; i < a; i++)
            {
                k+=1;
                if((a>k-6) |(a<k))
                {
                    File.WriteAllText(outputpath, i.ToString());
                }
            }

        }
    }
}
