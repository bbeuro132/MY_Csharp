using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace basic0609
{
    class Exam01
    {
        static void Main(string[] args)
        {
            /* 1번
            int[] arr = { 20, 34, 22, 14, 36, 23, 67 };

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            int avg = sum / arr.Length;
            Console.WriteLine(sum);
            Console.WriteLine(avg);*/


            /*2번
            int[] arr = new int[100];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (i + 1);

                if (arr[i] % 5 == 0)
                {
                    Console.Write("{0} ", arr[i]);
                }

                if (i == 90)
                {
                    break;
                }
            }
            */


            /* 3번
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int[] newArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[arr.Length - 1 - i];
                Console.WriteLine(newArr[i]);
            }*/

            /* 4번
            int[][] arr = new int[5][];

            arr[0] = new int[] { 1, 2 };
            arr[1] = new int[] { 2, 4, 6 };
            arr[2] = new int[] { 3, 6 };
            arr[3] = new int[] { 4, 8, 10, 12 };
            arr[4] = new int[] { 10 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("arr[{0}][{1}] = {2} ", i,j,arr[i][j]);
                }
                Console.WriteLine();
            }
            */


            /*5번
            int[,] arr1 = {
                {1,2,3}, {4,5,6}, {7,8,9}
            };
            int[,] arr2 =
            {
                {10,20,30}, {40,50,60}, {70,80,90}

            };

            int[,] newArr = new int[3,3];

            Console.WriteLine(newArr.GetLength(2));
            
            /*
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    newArr[i,j] = arr1[i,j] + arr2[i,j];
                    Console.Write("{0} ", newArr[i,j]);
                }
                Console.WriteLine();
            }*/


            /* 6번
            int[,] arr = new int[9,9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    arr[i, j] = (i + 1) * (j + 1);
                    Console.Write("{0}X{1}={2}\t", (j+1), (i+1), arr[i,j]);
                }
                Console.WriteLine();
            }
            */

            /* 7번
            Random rand = new Random();

            string[] first = { "김", "박", "이", "최", "장" };
            string[] middle = { "바", "사", "아", "자", "차" };
            string[] last = { "가", "나", "다", "라", "마" };
            string temp1, temp2, temp3;
            string[] full = new string[50];

            StreamWriter writer;
            writer = File.CreateText("writeTest.txt");

            while (true)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("파일 제어 프로그램 v1.1");
                Console.WriteLine("------------------------");
                Console.WriteLine("1. 이름 생성하여 파일에 저장하기");
                Console.WriteLine("2. 파일에서 이름 읽어오기");
                Console.WriteLine("3. 프로그램 종료");
                Console.WriteLine("------------------------");
                Console.Write("메뉴를 선택하세요 : ");
                int select = Convert.ToInt32(Console.ReadLine());

                if (select == 1)
                {
                    for (int i = 0; i < 50; i++)
                    {
                        temp1 = last[rand.Next(last.Length)];
                        temp2 = first[rand.Next(first.Length)];
                        temp3 = middle[rand.Next(middle.Length)];

                        full[i] = temp2 + temp3 + temp1;
                        writer.WriteLine(full[i]);
                    }
                    writer.Close();
                }
                else if (select == 2)
                {
                    for (int i = 0; i < 50; i++)
                    {
                        Console.WriteLine(full[i]);
                    }

                }
                else if (select == 3)
                {
                    Console.WriteLine("프로그램을 종료합니다.");
                    Environment.Exit(0);
                }

            }
              */            
            
            
            
            Random rand = new Random();
            
            int[] lotto = new int[6];
            int i = 0;
            int x = 0;

            do
            {
                lotto[i] = rand.Next(6) + 1;

                for (int j = 0; j < i; j++)
                {
                    if (lotto[j] == lotto[i])
                    {
                        Console.WriteLine("중복 발견");
                        i--;
                    }
                }

                i++;
            } while (i < lotto.Length);


            while (x < lotto.Length)
            {
                Console.Write(lotto[x] + " ");
                x++;
            }
        }
    }
}
