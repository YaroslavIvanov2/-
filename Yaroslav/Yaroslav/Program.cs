using System;

namespace Yaroslav
{
    class Program
    {
        static void Main(string[] args)
        {
            int money;
            string auvtomat;
            Console.WriteLine("Вставьте купюру");
            money = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Вложенно "+ money + " рублей");
            int кофе = 30, чай = 25, капучинно = 35, американо = 40, лате = 35;
            Console.WriteLine("Выберите напиток: кофе = 30, чай = 25, капучинно = 35, американо = 40, лате = 35");
            auvtomat = Console.ReadLine();
            switch (auvtomat){
                case "кофе":
                    if (money < кофе)
                    {
                        int i;
                        i = кофе - money;
                        Console.WriteLine("Вам не хватает " + i + " рублей");
                    }
                    else if (money >= кофе)
                    {
                        Console.WriteLine("Ваш напиток кофе");
                        int a = money - кофе;
                        Console.WriteLine("Ваша сдача " + a);
                    }
                    break;
                case "чай":
                    Console.WriteLine("Ваш напиток чай");
                    int b = money - чай;
                    Console.WriteLine("Ваша сдача " + b);
                    break;
                case "капучинно":
                    Console.WriteLine("Ваш напиток капучинно");
                    int c = money - капучинно;
                    Console.WriteLine("Ваша сдача " + c);
                    break;
                case "американо":
                    Console.WriteLine("Ваш напиток американо");
                    int n = money - американо;
                    Console.WriteLine("Ваша сдача " + n);
                    break;
                case "лате":
                    Console.WriteLine("Ваш напиток лате");
                    int t = money - лате;
                    Console.WriteLine("Ваша сдача " + t);
                    break;
                default:
                        Console.WriteLine("Вы ввели не существующий напиток");
                    break;
            }

            Console.Read();
        }
    }
}
