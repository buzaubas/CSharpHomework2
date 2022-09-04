using System;
using System.Collections.Generic;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }

            Task25();
            Console.ReadLine();
        }

        static void Task1(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void Task2(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine("Max element: " + arr[arr.Length - 1]);
        }

        static void Task3(ref int[] arr, int index)
        {
            for (int a = index; a < arr.Length - 1; a++)
            {
                arr[a] = arr[a + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
        }

        static void Task4()
        {
            //массив создается внутри функций
            int[] numbers = { 1, 3, 4, 9, 2 };
            Task1(numbers);
            int required_number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == required_number)
                {
                    for (int a = i; a < numbers.Length - 1; a++)
                    {
                        numbers[a] = numbers[a + 1];
                    }
                }
            }
            Array.Resize(ref numbers, numbers.Length - 1);
            Task1(numbers);
        }

        static void Task5()
        {
            int[] numbers = { 1, 3, 4, 9, 2 };
            Task1(numbers);
            Console.WriteLine();
            Console.Write("Enter index: ");
            int required_index = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value: ");
            int required_value = Convert.ToInt32(Console.ReadLine());
            int[] new_numbers = new int[numbers.Length + 1];
            int j = 0;
            for (int i = 0; i < numbers.Length + 1; i++)
            {
                if(required_index != i)
                {
                    new_numbers[i] = numbers[j];
                    j++;
                }
                else
                {
                    new_numbers[i] = required_value;
                }
            }
            Task1(new_numbers);
        }

        static void Task6()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 4};
            Task1(numbers);
            Console.WriteLine();
            int count = 0;
            int index_one = -1;
            int index_two = 0;
            List<int> list_numbers = new List<int>(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                count = 0;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if(numbers[i] == numbers[j])
                    {
                        count++;
                        index_two = j;
                    }
                }
                if(count == 1)
                {
                    index_one = i;
                }
            }
            if(index_one != -1)
            {
                list_numbers.RemoveAt(index_two);
                list_numbers.RemoveAt(index_one);
            }
            Array.Resize(ref numbers, numbers.Length - 2);
            numbers = list_numbers.ToArray();
            Task1(numbers);
        }

        static void Task7()
        {
            string text = Console.ReadLine();
            string[] wordArray = text.Split(' ');
            List<string> list = new List<string>(wordArray);
            string[] to_delete = new string[wordArray.Length];
            int index = 0;

            for(int i = 0; i < wordArray.Length; i++)
            {
                foreach (var item in wordArray[i])
                {
                    if (item == 'a')
                    {
                        to_delete[index] = wordArray[i];
                        index++;
                    }
                }
            }

            for(int i = 0; i < to_delete.Length; i++)
            {
                list.Remove(to_delete[i]);
            }

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }

        static void Task8()
        {
            string text = Console.ReadLine();
            string[] wordArray = text.Split(' ');

            List<string> list = new List<string>(wordArray);

            char[] letters_x = new char[wordArray[wordArray.Length-1].Length];
            for (int i = 0; i < letters_x.Length; i++)
            {
                letters_x[i] = wordArray[wordArray.Length - 1][i];
            }

            string[] to_delete = new string[50];
            int index = 0;

            for (int i = 0; i < wordArray.Length; i++)
            {
                foreach (var item in wordArray[i])
                {
                    for (int j = 0; j < letters_x.Length; j++)
                    {
                        if (item == letters_x[j])
                        {
                            to_delete[index] = wordArray[i];
                            index++;
                        }
                    }
                }
            }

            for (int i = 0; i < to_delete.Length; i++)
            {
                list.Remove(to_delete[i]);
            }

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }

        static void Task9()
        {
            string text = Console.ReadLine();
            string[] wordArray = text.Split(' ');

            int[] words_replace = new int[wordArray.Length];
            int index = 0;

            for (int i = 0; i < wordArray.Length; i++)
            {
                if (wordArray[i][0] == wordArray[i][wordArray[i].Length - 1])
                {
                    words_replace[index] = i;
                    index++;
                }
            }

            for (int i = 0; i < words_replace.Length; i++)
            {
                wordArray[words_replace[i]] = string.Format("[{0}]", wordArray[words_replace[i]]);
            }
            foreach (var item in wordArray)
            {
                Console.Write(item + " ");
            }
        }

        static void Task10()
        {
            //не знаю как решить
        }

        static void Task11()
        {
            //не знаю как решить
        }

        static void Task12()
        {
            int[,] square = new int[4, 4];
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    square[i, j] = random.Next(0, 9);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(square[i, j] + " ");
                }
                Console.Write('\n');
            }

            Console.WriteLine();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (square[0, j] != square[1, j] && square[0, j] != square[2, j] && square[0, j] != square[3, j] && square[1, j] != square[2, j] && square[1, j] != square[3, j] && square[2, j] != square[3, j])
                        Console.Write(square[i, j] + " ");
                }
                Console.Write('\n');
            }
        }

        static void Task13()
        {
            Console.WriteLine("Enter some symbols: ");
            char input;
            int spaceCount = 0;
            do
            {
                input = Console.ReadKey().KeyChar;
                if (input == ' ')
                    spaceCount++;
            }
            while (input != '.');
            Console.WriteLine(' ');

            Console.WriteLine("Quantity of spaces: " + spaceCount);
        }

        static void Task14()
        {
            Console.WriteLine("Enter ticket");
            string ticket = Console.ReadLine();
            int[] numbers = new int[ticket.Length];
            for (int i = 0; i < ticket.Length; i++)
            {
                numbers[i] = int.Parse(ticket[i].ToString());
            }

            if (numbers[0] + numbers[1] + numbers[2] == numbers[3] + numbers[4] + numbers[5])
            {
                Console.WriteLine("Lucky");
            }
            else
            {
                Console.WriteLine("Not LUcky!");
            }
        }

        static void Task15()
        {
            int e, count = 0;
            char i;
            for (; ; )
            {
                Console.WriteLine("Enter symbol->");
                e = Console.Read();

                if (e >= 65 && e <= 90)
                {
                    e += 32;
                    i = (char)e;
                    Console.WriteLine(i);

                }
                else if (e >= 97 && e <= 122)
                {
                    e -= 32;
                    i = (char)e;
                    Console.WriteLine(i);
                }
                else if (e == 46)
                {
                    break;
                }
                else
                {
                    i = (char)e;
                    Console.WriteLine(i);
                }
                count++;

            }
            Console.WriteLine("Number of symbols" + count);

        }

        static void Task16()
        {
            string number = Console.ReadLine();
            string[] rev_number = number.Split();
            Array.Reverse(rev_number);
            for (int i = 0; i < rev_number.Length; i++)
            {
                Console.Write(rev_number[i]);
            }
        }

        static void Task17()
        {
            float[] A = new float[5];
            float[,] B = new float[3, 4];

            for (int i = 0; i < A.Length; i++)
                A[i] = Convert.ToInt32(Console.ReadLine());

            Random randNum = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    B[i, j] = randNum.Next(1, 10);
            }

            //вывод
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i]);
            }

            Console.WriteLine('\n');

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(B[i, j]);
                }
                Console.Write('\n');
            }

            float[] AB = new float[17];
            int index = 0;
            for (int i = 0; i < A.Length; i++)
            {
                AB[index] = A[i];
                index++;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    AB[index] = B[i, j];
                    index++;
                }
            }

            Console.WriteLine('\n');
            Array.Sort(AB);
            Console.WriteLine(AB[0]); //общий минимальный
            Array.Reverse(AB);
            Console.WriteLine(AB[0]); //общий максимальный

            float sumAB = new float();

            for (int i = 0; i < A.Length; i++)
            {
                sumAB += A[i];
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sumAB += B[i, j];
                }
            }

            Console.WriteLine('\n');
            Console.Write(sumAB); //сумма

            float compAB = new float();
            compAB = 1;

            for (int i = 0; i < A.Length; i++)
            {
                compAB *= A[i];
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    compAB *= B[i, j];
                }
            }

            Console.WriteLine('\n');
            Console.Write(compAB); //произведение

            float oddAB = new float();

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                    oddAB += A[i];
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (B[i, j] % 2 == 0)
                        oddAB += B[i, j];
                }
            }

            Console.WriteLine('\n');
            Console.Write(oddAB); //сумма четных

            float evenAB = new float();

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 != 0)
                    evenAB += A[i];
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j % 2 != 0)
                        evenAB += B[i, j];
                }
            }

            Console.WriteLine('\n');
            Console.Write(evenAB); //сумма нечетных

            //общий максимальный элемент
        }

        static void Task18()
        {
            string word = "drragging";

            for (int i = 0; i < (word.Length - 1); i++)
            {
                if (word[i] == word[i + 1])
                {
                    string letter = word[i].ToString();
                    word = word.Replace(letter, "1");
                }
            }

            Console.WriteLine(word);
        }

        static void Task19()
        {
            string text = Console.ReadLine();

            string[] textArr = text.Split(' ');

            foreach (var item in textArr)
            {
                int num = 0;
                if (Int32.TryParse(item, out num))
                {
                    Console.WriteLine("Hmm, number");
                }
            }
        }

        static void Task20()
        {
            string text = Console.ReadLine();

            string[] wordArray = text.Split(' ');

            //foreach(var item in wordArray)
            //{
            //    if (item.Equals("one"))
            //    {
            //        Console.WriteLine("Yes, contains");
            //        break;
            //    }
            //}

            if (text.Contains("one"))
            {
                Console.WriteLine("Yes, contains");
            }
        }

        static void Task21()
        {
            string text = Console.ReadLine();

            string[] textArr = text.Split(' ');

            foreach (var item in textArr)
            {
                int num = 0;
                char ch;
                if (!Int32.TryParse(item, out num) && !Char.TryParse(item, out ch))
                {
                    Console.WriteLine("Not letter and not number found");
                }
            }
        }

        static void Task22()
        {
            string text = Console.ReadLine();

            string[] textArr = text.Split(' ');

            string[] letterArr = new string[textArr.Length];

            int k = 0;

            foreach (var item in textArr)
            {
                string fLetters = item[0].ToString();
                letterArr[k++] = fLetters;
            }

            foreach (var item in letterArr)
            {
                int l = 0;
                Console.WriteLine("Letter " + item + ": ");
                for (int i = 0; i < letterArr.Length; i++)
                {
                    if (letterArr[i] == item)
                    {
                        l++;
                    }
                }
                Console.WriteLine(l);
            }
        }

        static void Task23()
        {
            string text = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'p' || text[i] == 'P')
                {
                    count++;
                }
            }
            Console.Write("Number of p: " + count);
        }

        static void Task24()
        {
            string text = Console.ReadLine();
            string[] words = text.Split();
            int count = words.Length;
            Console.WriteLine("Number of words: " + count);
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }

        static void Task25()
        {
            string text = Console.ReadLine();
            string[] wordArray = text.Split(' ');

            
            int count = 0;

            for (int i = 0; i < wordArray.Length; i++)
            {
                if (wordArray[i][0] == wordArray[i][wordArray[i].Length - 1])
                {
                    count++;
                }
            }

            Console.WriteLine("Number of words with the same first and last letters: " + count);
            //слова из одной буква он также будет считать

        }
    }
}
