using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
//참조에서 system.web.extensions를 반드시 추가한다
//추가해야만 해당 주소에서 반환되는 json을 내가 쓰기 편하게 parsing 가능함

namespace KakaoMapApi
{
    public class KaKaoApi
    {
        //ListBox에 있는 지명을 클릭하고
        //그 지명을 검색한 뒤,
        //그 지명과 연관된 지역들을 반환하는 함수
        public static List<MyLocale> Search(string qstr)
        {
            List<MyLocale> mls = new List<MyLocale>();

            string site = "https://dapi.kakao.com/v2/local/search/keyword.json";
            string query = $"{site}?query={qstr}";

            //주어진 주소에 따라서
            //자료들을 요청함
            WebRequest request = WebRequest.Create(query);

            string rkey = "2a803e203eb5eec396ca091cc371443c";
            string header = "KakaoAK " + rkey;
            request.Headers.Add("Authorization", header);

            //요청된 것을 읽어들이는 작업(카카오에서 보내온 응답을 읽는 과정)
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            //UTF-8 형태로 읽는다.
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);

            string json = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();


            //var => foreach문에서 쓰임
            //string이나 int같은 그런 변수들에서 활용된다.(foreach문)
            //임시변수? object와 매우 유사
            //임시 객체라고 보면 된다.

            //이렇게 객체형태로 받아들이는 이유는 json이 객체이기 때문
            //그렇기에 임의의 객체 변수로 값을 받아오는 것이다
            dynamic dob = js.Deserialize<dynamic>(json); //var과 비슷한 것

            //json 객체에서 docuent 속성의 값들을 받아온다.
            dynamic docs = dob["documents"];

            object[] buf = docs;
            int length = buf.Length;

            //dynamic은 프로그램이 실행되어야지만 그 때에 타입이 결정됨

            //장소명, 위도, 경도를 받아올 것임
            for (int i = 0; i < length; i++)
            {
                string locale_name = docs[i]["place_name"];
                double x = double.Parse(docs[i]["x"]);
                double y = double.Parse(docs[i]["y"]);
                mls.Add(new MyLocale(locale_name, y, x));
            }


            return mls;
        }

       
    }
}
