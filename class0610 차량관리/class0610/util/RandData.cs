using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class0610.util
{
    class RandData
    {
        Random rand = new Random();

        string[] name = { "홍길동", "김길동", "박길동",
                                "최길동", "이길동" };

        string[] tel = {"010-1234-5678",
                            "010-4321-5678",
                            "010-3478-1278",
                            "010-4523-1978",
                            "010-7890-2134"};

        string[] address = { "대구시 동구 신천3동",
                                "대구시 동구 신천4동",
                                "대구시 동구 신천5동",
                                "대구시 동구 신천6동",
                                "대구시 동구 신천7동"};

        String[] model = { "SM6", "쏘나타", "싼타페", "K7", "그랜져"};
        String[] color = { "블랙", "은색", "흰색", "회색", "빨강"};
        int[] year = { 2016,2017,2015,2014,2018};
        String[] company = {"삼성르노", "현대", "기아", "현대", "기아"};

        public string getName()
        {
            return name[rand.Next(name.Length)];
        }
        public string getTel()
        {
            return tel[rand.Next(tel.Length)];
        }
        public string getAddress()
        {
            return address[rand.Next(address.Length)];
        }
        public string getModel()
        {
            return model[rand.Next(model.Length)];
        }
        public string getColor()
        {
            return color[rand.Next(color.Length)];
        }
        public int getYear()
        {
            return year[rand.Next(year.Length)];
        }
        public string getCompany()
        {
            return company[rand.Next(company.Length)];
        }
    }
}
