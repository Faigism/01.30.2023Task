using System;

namespace _01._30._2023HomeTask_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] st1 = new Student[0];
            int num;
            do
            {
                Console.WriteLine("1. Butun telebelere bax: ");
                Console.WriteLine("2. Telebeler uzre axtaris et: ");
                Console.WriteLine("3. Telebe elave et: ");
                Console.WriteLine("0. Menudan cix: ");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 0:
                        num = -1;
                        Console.WriteLine("Eminsiniz?...Y/N");
                        if (Console.ReadLine()=="Y")
                        {
                            num = 0;
                        }
                        break;
                    case 1:
                        foreach (var item in st1)
                        {
                            Console.WriteLine($"Fullname: {item.Fullname} - Qrup No: {item.GroupNo}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Axtaris deyerini daxil edin...");
                        string value = Console.ReadLine();
                        foreach (var item in st1)
                        {
                            if (item.Fullname.Contains(value) || item.GroupNo.Contains(value))
                            {
                                Console.WriteLine($"Fullname: {item.Fullname} - Qrup No: {item.GroupNo}");
                            }
                        }
                        break;
                    case 3:
                        string fullName;
                        int count = 0;
                        do
                        {
                            if (count==0)
                            {
                                Console.WriteLine("Fullname daxil edin: ");
                                fullName = Console.ReadLine();
                                count++;
                            }
                            else
                            {
                                Console.WriteLine("Fulname daxil edin.(Ilk herfleri boyuk diger herfleri kicik olmalidir");
                                fullName = Console.ReadLine();
                            }
                        } while (true);
                    default:
                        Console.WriteLine("Yanlis secim etdiniz yeniden secim edin..");
                        break;
                }
            } while (num!=0);
            

        }
    }
}
