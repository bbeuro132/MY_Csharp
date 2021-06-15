﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_0611
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();//2. 메인에 Random 함수 생성하고 매개 변수로 전달하는 것도 싱글톤 개념이 될 수 있음.
            //객체 덩어리 = 인스턴스 


            for (int i = 0; i < 5; i++)
            {
                SingleTest st1 = new SingleTest(r);// 생성자의 매개 변수로 잡음
                Console.WriteLine("인스턴스: " + st1.getData());

                //Console.WriteLine(new SingleTest().getData());
                Console.WriteLine("싱글톤: " + SingleTest.getInst(r).getData()); //싱글톤은 계속 같은 값으로 생성, 똑같은 User가 계속 접속
            }
        }
    }
}
