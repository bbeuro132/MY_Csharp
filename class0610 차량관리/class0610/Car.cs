using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class0610
{
    class Car
    {
        //클래스 변수
        public const string JIJUM = "동대구 영업소";

        //인스턴스 변수 (객체 내부에 잡히는 변수이기 때문에 인스턴스 변수
        private string company;
        private string color;
        private string price;
        private string model;

        public Car()
        {
            company = "기아";
            color = "블랙";
            price = "3천만원";
            model = "K7";
        }
        
        public Car(string company, string color, string price, string model)
        { //메소드 오버로딩
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

        public void setModel(string model)
        {
            this.model = model;
        }
        public void setPrice(string price)
        {
            this.price = price;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public void setCompany(string company)
        {
            this.company = company;
        }

        public string getModel()
        {
            return model;
        }
        public string getPrice()
        {
            return price;
        }
        public string getColor()
        {
            return color;
        }
        public string getCompany()
        {
            return company;
        }
    }
}
