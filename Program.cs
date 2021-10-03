using System;
using System.Text;

namespace laba2
{
    class Program
    {
        static void Main(string[] argc)
        {
            Console.WriteLine("\tТИПЫ");
            Console.WriteLine("Задание 1.A");
            Console.WriteLine("Введите переменную типа bool : ");
            bool bolean = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Введите переменную типа byte : ");
            byte bit1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите переменную типа sbyte : ");
            sbyte sbit1 = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Введите переменную типа short : ");
            short shot1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите переменную типа ushort : ");
            ushort ushot1 = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Введите переменную типа int : ");
            int int1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите переменную типа uint : ");
            uint uint1 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Введите переменную типа long : ");
            long long1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введите переменную типа ulong : ");
            ulong ulong1 = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Введите переменную типа float : ");
            float float1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите переменную типа double : ");
            double double1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите переменную типа decimal : ");
            decimal decimal1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите переменную типа char : ");
            char char1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите переменную типа string : ");
            string string1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите переменную типа object : ");
            object object1 = Console.ReadLine();
            Console.WriteLine("Переменная типа bool : {0}\nПеременная типа byte : {1}\nПеременная типа sbyte : {2}\nПеременная типа short : {3}\nПеременная типа ushort : {4}\nПеременная типа int : {5}\nПеременная типа uint : {6}\nПеременная типа long : {7}\nПеременная типа ulong : {8}\nПеременная типа float : {9}\nПеременная типа double : {10}\nПеременная типа decimal : {11}\nПеременная типа char : {12}\nПеременная типа string : {13}\nПеременная типа object : {14}", bolean, bit1, sbit1, shot1, ushot1, int1, uint1, long1, ulong1, float1, double1, decimal1, char1, string1, object1);

            Console.WriteLine("\nЗадание 1.Б\n\n");
            short a = 10;
            float b = a;
            double c = a;
            long d = a;
            int e = a;
            decimal f = a;
            Console.WriteLine("Неявное приведение из типа short (значение {0}) в типы : \n1) float = {1}\n2) double = {2}\n3) long = {3} \n4) int = {4}\n5) decimal = {5}", a, b, c, d, e, f);
            uint b1 = (uint)a;
            byte c1 = (byte)a;
            ulong d1 = (ulong)a;
            sbyte e1 = (sbyte)a;
            ushort f1 = (ushort)a;
            Console.WriteLine("Явное приведение из типа short (значение {0}) в типы : \n1) uint = {1}\n2) byte = {2}\n3) ulong = {3} \n4) sbyte = {4}\n5) ushort = {5}", a, b1, c1, d1, e1, f1);

            Console.WriteLine("\nЗадание 1.C\n\n");
            int massage = 1;
            object box = massage;
            int unbox = (int)massage;

            Console.WriteLine("\nЗадание 1.Д\n\n");
            var var1 = 10.1;
            Console.WriteLine("неявно заданный тип перменной var1, значение 10.1 : {0}", var1.GetType());

            Console.WriteLine("\nЗадание 1.E\n\n");
            int? nullabletype = null;
            Console.WriteLine("Nullable после инициализации : {0}", nullabletype);
            nullabletype = 10;
            Console.WriteLine("Nullable после присвоения значения : {0}", nullabletype);

            Console.WriteLine("\nЗадание 1.Ф\n\n");

            //var var2 = 1;
            //double var3 = 1.1;
            //var2 = (double)var3;

            Console.WriteLine("\n\tСТРОКИ\n\n");

            Console.WriteLine("\nЗадание 2.А\n\n");
            string str1, str2;
            str1 = "two words";
            str2 = "two words";
            int result = string.Compare(str1, str2);
            if (result == 0)
            {
                Console.WriteLine("Строковые литералы идентичны.");
            }
            else
            {
                Console.WriteLine("Строковые литералы отличаются.");
            }

            Console.WriteLine("\nЗадание 2.Б\n\n");

            string str3, str4, str5, strCOPY;

            str3 = (" onse ");
            str4 = (" dosse ");
            str5 = (" trossi ");
            strCOPY = null;
            Console.WriteLine("Строка 1 : {0}\nСтрока 2 : {1}\nСтрока 3 : {2}\n", str3, str4, str5);
            Console.WriteLine($"Конкатенация строк : {string.Concat(str3, str4, str5)}");
            strCOPY = str3;
            Console.WriteLine("Копирование строки str3 в strCOPY: {0}", strCOPY);
            strCOPY = str5.Substring(3);
            Console.WriteLine("Выделение подстроки : {0}", strCOPY);

            string text = "onse dosse tresse";

            string[] words = text.Split(new char[] { ' ' });

            Console.WriteLine("Разделение строки на слова :");

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }

            str3 = str4.Insert(4, str5.Substring(3));

            Console.WriteLine("Вставка подстроки в заданную позицию : {0}", str3);

            Console.WriteLine($"Удаление заданной подстроки: {str3 = str3.Remove(3)}");

            Console.WriteLine("\nЗадание 2.С\n\n");

            string pusto = "";
            string strNULLL = null;
            bool ch = string.IsNullOrEmpty(pusto);
            bool nch = string.IsNullOrEmpty(strNULLL);
            Console.WriteLine("Проверка значения пустой строки : {0}\nПроверка значния нулл строки : {1}", ch, nch);

            Console.WriteLine("\nЗадание 2.Д\n\n");

            StringBuilder sb = new StringBuilder();
            sb.Append("My");
            sb.Append("Name");
            Console.WriteLine("Строка после добавления символов : {0}", sb);

            sb.Remove(0, 1);
            sb.Remove(4, 1);
            Console.WriteLine("Строка после удаления первого и последнего символа : {0}", sb);

            sb.Insert(0, "M");
            sb.Insert(5, "e");
            Console.WriteLine("Строка после возврата первого и последнего символа : {0}", sb);

            Console.WriteLine("\nЗадание 3.А\n\n");
            int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("{0} {1}", array[0, 0], array[0, 1]);
            Console.WriteLine("{0} {1}", array[0, 2], array[1, 0]);
            Console.WriteLine("{0} {1}", array[1, 1], array[1, 2]);
            Console.WriteLine("\nЗадание 3.Б\n\n");
            string[] massivStrok = new string[] { "Stroka1", "Stroka2", "Stroka3" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(massivStrok[i]);
            }
            Console.WriteLine(massivStrok.Length);

            Console.WriteLine("Меняем значение элемента, введите номер элемента, и то на что надо заменить : ");
            int num = Convert.ToInt32(Console.ReadLine());
            string newSTR = Convert.ToString(Console.ReadLine());

            massivStrok[num] = newSTR;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(massivStrok[i]);
            }
            Console.WriteLine("\nЗадание 3.C\n\n");
            int[,] numbers = new int[5, 5];
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        int p = Convert.ToInt32(Console.ReadLine());

                        numbers[i, j] = p;
                    }
                }
                if (i == 1)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        int p = Convert.ToInt32(Console.ReadLine());

                        numbers[i, j] = p;
                    }
                }
                if (i == 2)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        int p = Convert.ToInt32(Console.ReadLine());

                        numbers[i, j] = p;
                    }
                }
            }
            Console.WriteLine($"\n\n{numbers[0, 0]} {numbers[0, 1]}\n{numbers[1, 0]} {numbers[1, 1]} {numbers[1, 2]} \n{numbers[2, 0]} {numbers[2, 1]} {numbers[2, 2]} {numbers[2, 3]}");

            Console.WriteLine("\nЗадание 3.Д\n\n");

            var mass = new object[5];
            var strings = "А может быть это строка?";
            mass[0] = 1;
            mass[1] = 2;
            mass[2] = 3;
            mass[3] = 4;
            mass[4] = 5;
            Console.WriteLine($"{strings} - (всё-таки строка) тип {strings.GetType()}");
            Console.WriteLine($"{mass[0]} - (элемент массива) тип {mass.GetType()}");

            Console.WriteLine("\nЗадание 4.A\n\n");
            ValueTuple<int, string, char, string, ulong> ya = (18, "Anton", 'm', "Pinchuk", 178);

            Console.WriteLine("\nЗадание 4.Б");
            Console.WriteLine($" {ya}");

            Console.WriteLine(ya.Item1);
            Console.WriteLine(ya.Item3);
            Console.WriteLine(ya.Item4);

            Console.WriteLine("\nЗадание 4.С");
            
            var a11 = ya.Item1;
            var b11 = ya.Item2;
            var c11 = ya.Item3;
            var d11 = ya.Item4;

            Console.WriteLine(a11);
            Console.WriteLine(b11);
            Console.WriteLine(c11);
            Console.WriteLine(d11);

            var (first, _, _, fourth, fifth) = ya;

            Console.WriteLine("\nЗадание 5");
            int[] massiv = { 11, 22, 33, 44 };
            Console.WriteLine(zad5(massiv, "Water"));
           
            (int, int, int, char) zad5(int[] arrA, string strA)
            {
                int max, min, sum = 0;
                min = max = arrA[0];
                foreach (int i in arrA)
                {
                    if (i < min)
                    {
                        min = i;
                    }
                }
                foreach (int i in arrA)
                {
                    if (i > max)
                    {
                        max = i;
                    }
                }
                foreach (int i in arrA)
                {
                    sum += i;
                }
                (int, int, int, char) TupleB = (max, min, sum, strA[0]);
                return TupleB;
            }
            Console.WriteLine("\nЗадание 6.А");
            zad6b();
            zad6c();


            void zad6b(){
                checked
                {
                    int checkedd = 2147483647;
                    Console.WriteLine(checkedd);
                }
            }
            void zad6c() {
                unchecked
                {
                    int uncheckedd = 2147483647;
                    Console.WriteLine(uncheckedd);
                }
            };
        }
    }
}



