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
            /*
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
            */
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
            /*
            int vse_v = 0;
            using (var fs = File.OpenRead("Bagazh"))
            using (var br = new BinaryReader(fs))
            {
                for (int i = 0; i < 4; i++)
                {
                    int veshi = br.ReadInt32();
                    double m = br.ReadDouble();
                    vse_v += veshi;
                }
                for (int i = 0; i < 4; i++)
                {
                    int veshi = br.ReadInt32();
                    double m = br.ReadDouble();
                    if (veshi > 2)
                        Console.WriteLine($"багаж - {veshi} {m}");
                    if (veshi > vse_v / 4)
                        Console.WriteLine($"багаж - {veshi} {m}");
                }
            }
            */
            //c
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
                    if (veshi <= 1 && veshi <= massa)
                        Console.WriteLine("треш нафига тебе багаж");
                }
            }
            */

            // task 3
            /*
            using (var fs = File.Create("t"))
            using (var bw = new BinaryWriter(fs))
            {
                for (int i = 0; i < 4; i++)
                {
                    bw.Write(Console.ReadLine());
                    bw.Write(Console.ReadLine());
                    bw.Write(Console.ReadLine());
                }

            }
            Console.WriteLine("введите фамилию");
            string prover_f = Console.ReadLine();
            Console.WriteLine("введите инициалы");
            string prover_i = Console.ReadLine();
            using (var fs = File.OpenRead("t"))
            using (var br = new BinaryReader(fs))
            {
                for (int i = 0; i < 4; i++)
                {
                    string nomer = br.ReadString();
                    string fam = br.ReadString();
                    string init = br.ReadString();
                    if (prover_f == fam && prover_i == init)
                        Console.WriteLine(nomer);
                }


            }
            */

            // task 4
            /*
            using (var fs = File.Create("data"))
            using (var bw = new BinaryWriter(fs))
            {
                for (int i = 0; i < 4; i++)
                {
                    bw.Write(int.Parse(Console.ReadLine()));
                    bw.Write(int.Parse(Console.ReadLine()));
                    bw.Write(int.Parse(Console.ReadLine()));
                }

            }
            */
            // a
            /*
            int min = int.MaxValue;
            int max = int.MinValue;
            using (var fs = File.OpenRead("data"))
            using (var br = new BinaryReader(fs))
            {
                for (int i = 0; i < 4; i++)
                {
                    int chislo = br.ReadInt32();
                    int month = br.ReadInt32();
                    int year = br.ReadInt32();
                    if (year <= min)
                        min = year;
                        
                }
                Console.WriteLine(min);
            }
            */

            // b
            /*
            using (var fs = File.OpenRead("data"))
            using (var br = new BinaryReader(fs))
            {
                for (int i = 0; i < 4; i++)
                {
                    int chislo = br.ReadInt32();
                    int month = br.ReadInt32();
                    int year = br.ReadInt32();
                    if (month == 3 || month == 4 || month == 5)
                        Console.WriteLine($"{chislo}, {month}, {year}");
                }
            }
            */

            // c
            /*
            int min = int.MaxValue;
            int max = int.MinValue;
            int max1 = 0;
            int max2 = 0;
            using (var fs = File.OpenRead("data"))
            using (var br = new BinaryReader(fs))
            {
                for (int i = 0; i < 4; i++)
                {
                    int chislo = br.ReadInt32();
                    int month = br.ReadInt32();
                    int year = br.ReadInt32();
                    if (year >= max && month >= max && chislo >= max)
                    {
                        max = year;
                        max1 = month;
                        max2 = chislo;
                    }
                }
                Console.WriteLine($"{max}, {max1}, {max2}");

            }
            */

            // task 5
            /*
            using (var fs = File.Create("tovar"))
            using (var bw = new BinaryWriter(fs))
            {
                for (int i = 0; i < 4; i++)
                {
                    bw.Write(Console.ReadLine());
                    bw.Write(Console.ReadLine());
                    bw.Write(int.Parse(Console.ReadLine()));
                }

            }

            Console.WriteLine("Введите товар");
            string proverka = Console.ReadLine();
            int ves_kovlo = 0;
            using (var fs = File.OpenRead("Tovar"))
            using (var br = new BinaryReader(fs))
            {
                for (int i = 0; i < 4; i++)
                {
                    string name = br.ReadString();
                    string country = br.ReadString();
                    int kolvo = br.ReadInt32();
                    if (proverka == name)
                    {
                        ves_kovlo += kolvo;
                        Console.WriteLine(country);
                        Console.WriteLine(ves_kovlo);
                    }

                }

            } 
            */

            // task 6

            using (var fs = File.Create("assort"))
            using (var bw = new BinaryWriter(fs))
            {

                bw.Write("Мяч");
                bw.Write(100);
                bw.Write(2);
                bw.Write(100);

                bw.Write("Кукла");
                bw.Write(2445);
                bw.Write(6);
                bw.Write(100);

                bw.Write("Конструктор");
                bw.Write(5099);
                bw.Write(12);
                bw.Write(100);

                bw.Write("Конструктор");
                bw.Write(3999);
                bw.Write(12);
                bw.Write(100);

                bw.Write("Конструктор");
                bw.Write(15479);
                bw.Write(12);
                bw.Write(100);
 
                bw.Write("Мишка маленький");
                bw.Write(300);
                bw.Write(2);
                bw.Write(100);

                bw.Write("Мишка большой");
                bw.Write(1500);
                bw.Write(5);
                bw.Write(100);

                bw.Write("Приставка");
                bw.Write(45997);
                bw.Write(12);
                bw.Write(100);

                bw.Write("Кубики");
                bw.Write(325);
                bw.Write(1);
                bw.Write(100);

                bw.Write("Кубики");
                bw.Write(500);
                bw.Write(1);
                bw.Write(100);

                bw.Write("Кубики");
                bw.Write(234);
                bw.Write(1);
                bw.Write(100);

                bw.Write("Машинка");
                bw.Write(3449);
                bw.Write(7);
                bw.Write(100);

            }

            // a
            /*
            using (var fs = File.OpenRead("assort"))
            using (var br = new BinaryReader(fs))
            {
                int counttoys = br.ReadInt32();
                for (int i = 0; i < counttoys; i++)
                {
                    string name = br.ReadString();
                    int price = br.ReadInt32();
                    int min_age = br.ReadInt32();
                    int max_age = br.ReadInt32();
                    if (price <= 14000 || min_age == 5 || max_age == 5)
                        Console.WriteLine(name);
                }
            }
            */

            //b
            /*
            int max = int.MinValue;
            using (var fs = File.OpenRead("assort"))
            using (var br = new BinaryReader(fs))
            {
                int counttoys = br.ReadInt32();
                for (int i = 0; i < counttoys; i++)
                {
                    string name = br.ReadString();
                    int price = br.ReadInt32();
                    int min_age = br.ReadInt32();
                    int max_age = br.ReadInt32();
                    if (name == "Конструктор" || price >= max)
                    {
                        max = price;
                        Console.WriteLine(max);
                    }
                }
            }
            */

            // v


        }
    }
}