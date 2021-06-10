using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class0610
{
    class Car2 //C# 스타일의 클래스
    {
        //클래스 변수
        public const string JIJUM = "동대구 영업소";

        //인스턴스 변수 (객체 내부에 잡히는 변수이기 때문에 인스턴스 변수
        private string company;
        private string color;
        private string price;
        private string model;

        public string Company { get => company; set => company = value; }
        public string Color { get => color; set => color = value; }
        public string Price { get => price; set => price = value; }
        public string Model { get => model; set => model = value; }

        public Car2(string company, string color, string price, string model)
        {
            this.company = company;
            this.color = color;
            this.price = price;
            this.model = model;
        }

        public void printCarInfo()
        {
            Console.WriteLine("제조사 : " + company);
            Console.WriteLine("색상 : " + color);
            Console.WriteLine("가격 : " + price);
            Console.WriteLine("모델 : " + model);
        }

        public override string ToString()
        {
            string str = "제조사 : " + company + "\n";
            str += "색상 : " + color + "\n";
            str += "가격 : " + price + "\n";
            str += "모델 : " + model + "\n";
            return str;
        }
    }
}
