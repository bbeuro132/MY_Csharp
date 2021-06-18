using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carFixMgr0611.handler
{
    class OraHandler
    {
        const string ORADB =
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
            "(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)" +
            "(SERVICE_NAME=XE)));" +
            "User Id=sqlDB;Password=1234;";
        OracleConnection conn;
        OracleCommand cmd;

        public OraHandler()
        {
            Console.WriteLine("객체 생성");
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
            dbConnect();
        }

        ~OraHandler() // '~' <-소멸자, 생성자와는 반대개념, 객체가 소멸할 때 호출됨
        {
            Console.WriteLine("객체 소멸");
            dbClose();
        }
        
        public void dbConnect()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공!");
            }
            catch(OracleException e)
            {
                Console.WriteLine("오라클 접속 에러!");
            }
        }

        public void dbClose()
        {
            try
            {
                conn.Close();
                Console.WriteLine("오라클 접속 해제!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 접속 해제 에러!");
            }
        }
    }
}
