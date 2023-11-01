using System;
using System.IO;

namespace FilesPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 13.2 
            //task 2

            // Создадим файл с книгами
            /*using (var fs = File.Create("Bibl"))
            using (var bw = new BinaryWriter(fs))
            {
                bw.Write(6);*/
            /* запись книг с консоли
            for (int i = 0; i < 10; i++)
            {
                bw.Write(Console.ReadLine());
                bw.Write(Console.ReadLine());
                bw.Write(int.Parse(Console.ReadLine()));
            }
            */
            /*bw.Write("Иванов");
            bw.Write("Информатика");
            bw.Write(1980);

            bw.Write("Петров");
            bw.Write("Информатика");
            bw.Write(1990);

            bw.Write("Сидоров");
            bw.Write("Как не опоздать на пары");
            bw.Write(2023);

            bw.Write("Пушкин");
            bw.Write("Как отчислить студентов");
            bw.Write(2016);

            bw.Write("Михайлюк");
            bw.Write("Не родись красивой");
            bw.Write(2000);

            bw.Write("Побежимов");
            bw.Write("Опасные рассказы про PHP");
            bw.Write(2020);
            }
            */

            // Задание а
            /*Console.WriteLine("Фамилия автора?");
            string searchAuthor = Console.ReadLine();

            using (var fs = File.OpenRead("Bibl"))
            using (var br = new BinaryReader(fs))
            {
                int countBook = br.ReadInt32(); // кол-во книг
                for (int i = 0; i < countBook; i++)
                {
                    string author = br.ReadString();
                    string book = br.ReadString();
                    int year = br.ReadInt32();

                    if (author == searchAuthor && year >= 1960)
                        Console.WriteLine($"{book} - {year}г.");
                }
            }*/
            /*
            // Задание б
            using (var fs = File.OpenRead("Bibl"))
            using (var br = new BinaryReader(fs))
            {
                int countBook = br.ReadInt32(); // кол-во книг
                for (int i = 0; i < countBook; i++)
                {
                    string author = br.ReadString();
                    string book = br.ReadString();
                    int year = br.ReadInt32();

                    if (book == "Информатика")
                        Console.WriteLine($"{author} - {year}г.");
                }
            }
            */

            // task 1

            using (var fs = File.Create("Bagazh"))
            using (var bw = new BinaryWriter(fs))
            {
                bw.Write(4);
                for (int i = 0; i < 4; i++)
                {
                    bw.Write(int.Parse(Console.ReadLine()));
                    bw.Write(double.Parse(Console.ReadLine()));
                }
            }
            // a
            /*
            Console.WriteLine("введите м");
            int massa = int.Parse(Console.ReadLine());
            using (var fs = File.OpenRead("Bagazh"))
            using (var br = new BinaryReader(fs))
            {
                for (int i = 0; i < 4; i++)
                {
                    int veshi = br.ReadInt32();
                    double m = br.ReadDouble();
                    int sr_bagazh = (int)(m / veshi);
                    if (sr_bagazh <= massa)
                        Console.WriteLine($"багаж - {veshi} {m}");
                }

            }
            */
            // b
            using (var fs = File.OpenRead("Bagazh"))
            using (var br = new BinaryReader(fs))
            {
                for (int i = 0; i < 4; i++)
                {
                    int veshi = br.ReadInt32();
                    double m = br.ReadDouble();
                    if (veshi > 2)
                        Console.WriteLine($"багаж - {veshi} {m}");
                }
                for (int i = 0; i < 4; i++)
                {
                    int veshi = br.ReadInt32();
                    double m = br.ReadDouble();
                    
                }

            }

        }
    }
}