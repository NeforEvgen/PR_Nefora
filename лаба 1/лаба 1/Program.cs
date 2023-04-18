using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Первое задание 1 части");
            Console.WriteLine("2 - Второе задание 1 части");
            Console.WriteLine("3 - Третье задание 1 части");
            Console.WriteLine("4 - Четвертое задание 1 части");
            Console.WriteLine("5 - Уравнение задание 2 части");
            Console.WriteLine("6 - Первое задание 3 части");
            Console.WriteLine("7 - Второе задание 3 части");
            Console.WriteLine("8 - Третье задание 3 части"); 
            Console.WriteLine("9 - Четвертое задание 3 части");
            Console.WriteLine();
            Console.Write("Выберите номер задачи от 1 до 9: ");
            int taskNumber = int.Parse(Console.ReadLine());

            switch (taskNumber)
            {
                case 1:
                    SolveTask1();
                    break;
                case 2:
                    SolveTask2();
                    break;
                case 3:
                    SolveTask3();
                    break;
                case 4:
                    SolveTask4();
                    break;
                case 5:
                    SolveTask1_2();
                    break;
                case 6:
                    SolveTask13();
                    break;
                case 7:
                    SolveTask23();
                    break;
                case 8:
                    SolveTask33();
                    break;
                case 9:
                    SolveTask43();
                    break;
                default:
                    Console.WriteLine("Неверный номер задачи");
                    break;
                    Console.WriteLine("Конец работы программы");
                    Console.ReadLine();
            }

            static void SolveTask1()
            {
                Console.WriteLine("Начало первой задачи");
                Console.WriteLine("Введите три числа, каждое на новой строке:");
                Console.Write("A=");
                double A = double.Parse(Console.ReadLine());
                Console.Write("B=");
                double B = double.Parse(Console.ReadLine());
                Console.Write("C=");

                double C = double.Parse(Console.ReadLine());
                double AB = Math.Abs(B - A); // Длина отрезка AB
                double BC = Math.Abs(C - B); // Длина отрезка BC
                double sum = AB + BC; // Сумма длин отрезков AB и BC

                Console.WriteLine("Длина отрезка AB: " + AB);
                Console.WriteLine("Длина отрезка BC: " + BC);
                Console.WriteLine("Сумма длин отрезков AB и BC: " + sum);
                Console.WriteLine("Конец первой задачи");
                Console.WriteLine();
            }

            static void SolveTask2()
            {
                Console.WriteLine("Начало второй задачи");

                double X = 2; // Количество килограммов яблок
                Console.Write("Введите сколько нужно килограмм яблок=");
                double Y = double.Parse(Console.ReadLine()); // Количество килограммов яблок
                double N = 100; // Стоимость X килограммов яблок

                double costPerKg = N / X; // Стоимость 1 килограмма яблок
                double totalCost = costPerKg * Y; // Стоимость Y килограммов яблок
                Console.WriteLine();
                Console.WriteLine("Количество килограммов яблок для нахождения цены:" + X);
                Console.WriteLine("Ценa этого количества яблок:" + N);
                Console.WriteLine("Цену скольки килограмм яблок нужно посчитать:" + Y);
                Console.WriteLine("Стоимость 1 килограмма яблок: " + costPerKg);
                Console.WriteLine("Стоимость " + Y + " килограммов яблок: " + totalCost);

                Console.WriteLine("Конец второй задачи");
                Console.WriteLine();
            }


            static void SolveTask3()
            {

                Console.WriteLine("Начало третей задачи");
                Console.Write("Введите пятизначное число= ");
                int number = int.Parse(Console.ReadLine());

                int thousands = number / 1000; // получаем тысячи
                int hundreds = (number / 100) % 10; // получаем сотни
                int tens = (number / 10) % 10; // получаем десятки
                int ones = number % 10; // получаем единицы

                int newNumber = thousands * 1000 + hundreds * 10 + tens * 100 + ones; // создаем новое число, меняя местами сотни и тысячи
                Console.WriteLine("Конвертируемое число:" + number);
                Console.WriteLine("Измененное число" + newNumber); // выводим новое число

                Console.WriteLine("Конец третей задачи");
                Console.WriteLine();
            }

            static void SolveTask4()
            {

                Console.WriteLine("Начало четвертой задачи");
                Console.Write("Введите норме дня года = ");
                int K = int.Parse(Console.ReadLine()); // Номер дня года
                int dayOfWeek = K % 7;
                Console.WriteLine("Номер дня недели для " + K + "-го дня года: " + dayOfWeek);

                Console.WriteLine("Конец четвертой задачи");
                Console.WriteLine();
            }
            static void SolveTask1_2()
            {
                Console.WriteLine();
                Console.WriteLine("Лаба1_2 решение уравнения");
                double x = 0.586;
                double y = 18.525;
                double z = 182.5;

                double s = Math.Abs(Math.Pow(x, x / y) - Math.Pow(3, 1.0 / 3) * Math.Pow(x / y, 1.0 / 3))
                           + (x - y) * ((Math.Cos(x) - z / (x - y)) / (1 + Math.Pow(x - y, 3)));
                Console.WriteLine("Решение уравнения: " + s);



            }
            static void SolveTask13()
            {
                Console.WriteLine();
                Console.WriteLine("Первая задача 3 части лабы"); // Задача 1

                Console.WriteLine("Введите 2 переменные целого типА:");
                Console.Write("A=");
                int A = int.Parse(Console.ReadLine());
                Console.Write("B=");
                int B = int.Parse(Console.ReadLine());
                if (A != B)
                {
                    A = B = Math.Min(A, B);
                }
                else
                {
                    A = B = Math.Max(A, B);
                }
                Console.WriteLine("Задача 1: A = {0}, B = {1}", A, B);
            }
            static void SolveTask23()
            {

                Console.WriteLine();
                Console.WriteLine("вторая задача 3 части лабы");// Задача 2

                Console.Write("Введите число которое вы хотите преобразовать в текст = ");
                int number = int.Parse(Console.ReadLine());
                string[] digits = { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
                string[] tens = { "", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
                int digit = number % 10;
                int ten = number / 10;
                string result = (ten > 1) ? tens[ten] + " " : "";
                result += (ten == 1) ? digits[number] : digits[digit];
                Console.WriteLine("Задача 2: {0}", result);
            }

            static void SolveTask33()
            {
                Console.WriteLine();
                Console.WriteLine("третья задача 3 части лабы"); // Задача 3

                Console.Write("Введите цену 1кг груш = ");
                double price = double.Parse(Console.ReadLine());
                for (int i = 1; i <= 15; i++)
                {
                    Console.WriteLine("Задача 3: {0} кг груш стоят {1} рублей", i, i * price);
                }
            }

            static void SolveTask43()
            {
                Console.WriteLine();// Задача 4
                Console.WriteLine("четвертая задача 3 части лабы");

                Console.Write("Введите сколько раз будет выполняться действие = ");
                int N = int.Parse(Console.ReadLine());
                double sum = 0;
                for (int i = 1; i <= N; i++)
                {
                    sum += 1.0 / i;
                }
                Console.WriteLine("Задача 4: Сумма ряда = {0}", sum);
            }
        }


  