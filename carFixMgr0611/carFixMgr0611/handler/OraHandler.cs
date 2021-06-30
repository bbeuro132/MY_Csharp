using carFixMgr0611.model;
using carFixMgr0611.ui;
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
            catch (OracleException e)
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

        public void insertDb()
        {
            string model = "그랜저";
            string cc = "2500cc이하";
            string number = "23가2345";
            string caryear = "2020년식";

            string query =
                string.Format("insert into car_t values " +
                "(CAR_T_SEQ.NEXTVAL, '{0}', '{1}', '{2}', '{3}')",
                model, number, cc, caryear);
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }

        public void insertDb(Receipt receipt)
        {
            try
            {
                string query =
                    string.Format("insert all " +
                    "into car_t values (car_t_seq.nextval, " +
                    "'{0}', '{1}', '{2}', '{3}')",
                    receipt.Car.Model, receipt.Car.Number, receipt.Car.Cc, receipt.Car.Year);

                query += string.Format("into customer_t values (CUSTOMER_T_SEQ.NEXTVAL, " +
                                        "'{0}', '{1}', '{2}', car_t_seq.currval)",
                                        receipt.Cust.Name, receipt.Cust.Tel,
                                        receipt.Cust.Birth);

                query += "select * from dual";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                List<RepairItem> itemList = receipt.ItemList;

                for (int i = 0; i < itemList.Count; i++)
                {
                    RepairItem item = itemList[i];

                    string queryItem =
                        string.Format("insert into REPAIR_ITEM_T values (repair_item_t_seq.nextval, " +
                                        "{0}, '{1}', {2}, car_t_seq.currval)",
                                        item.Idx, item.Repair, item.Price);
                    cmd.CommandText = queryItem;
                    cmd.ExecuteNonQuery();
                }

                string queryReceipt =
                    string.Format("insert into RECEIPT_T values " +
                                "(RECEIPT_T_SEQ.NEXTVAL, " +
                                "CUSTOMER_T_SEQ.currval, CAR_T_SEQ.currval, " +
                                "'{0}', " +
                                "(select staff_t.staff_id from " +
                                "STAFF_T where staff_t.name = '{1}'), {2})",
                                receipt.InDate, receipt.StaffName,
                                receipt.TotalPrice);

                cmd.CommandText = queryReceipt;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errMsg(e);
                Console.WriteLine(e.StackTrace);
            }

        }

        private void errMsg(OracleException e)
        {
            Console.WriteLine("에러내용 : " + e.Message);
            Console.WriteLine(e.StackTrace);
        }

        public void showDb()
        {
            string query = "select indate as 접수일, total_price as 총결제금액, " + 
                            "(select customer_t.name from CUSTOMER_T WHERE " + 
                            "CUSTOMER_T.CUST_ID = receipt_t.CUST_ID) as 고객명, " +
                            "(select staff_t.name from staff_T WHERE " + 
                            "staff_T.STAFF_ID = receipt_t.STAFF_ID) as 담당자 " + 
                            "from receipt_t";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            int count = 1;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine("번호: " + count);
                    Console.WriteLine("접수날짜: " + dr["접수일"]);
                    Console.WriteLine("결제금액: " + dr["총결제금액"]);
                    Console.WriteLine("고객명: " + dr["고객명"]);
                    Console.WriteLine("담당자: " + dr["담당자"]);
                    Console.WriteLine("-----------------------");
                    count++;
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }

            string query2 = "select repair as 수리항목, " + 
                            "price as 수리비 from REPAIR_ITEM_T " + 
                            "where CAR_ID=" + "(select CUSTOMER_T.CUST_ID " + 
                            "from customer_t " + 
                            "where customer_t.Name='박고객')";
            cmd.CommandText = query2;
            cmd.CommandType = System.Data.CommandType.Text;
            dr = cmd.ExecuteReader();
            count = 1;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine("번호: " + count);
                    Console.WriteLine("수리항목: " + dr["수리항목"]);
                    Console.WriteLine("수리비: " + dr["수리비"]);
                    Console.WriteLine("-----------------------");
                    count++;
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            dr.Close();
        }

        public List<ReceiptVO> getReceipt()
        {
            string query = "select indate as 접수일, total_price as 총결제금액, " +
                "(select customer_t.name from CUSTOMER_T WHERE " +
                "CUSTOMER_T.CUST_ID = receipt_t.CUST_ID) as 고객명, " +
                "(select staff_t.name from staff_T WHERE " +
                "staff_T.STAFF_ID = receipt_t.STAFF_ID) as 담당자 " +
                "from receipt_t";

            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            int count = 1;

            List<ReceiptVO> list = new List<ReceiptVO>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    /*Console.WriteLine("번호: " + count);
                    Console.WriteLine("접수날짜: " + dr["접수일"]);
                    Console.WriteLine("결제금액: " + dr["총결제금액"]);
                    Console.WriteLine("고객명: " + dr["고객명"]);
                    Console.WriteLine("담당자: " + dr["담당자"]);
                    Console.WriteLine("-----------------------");*/
                    ReceiptVO receiptVo = 
                        new ReceiptVO(dr["접수일"].ToString(), 
                                      Convert.ToInt32(dr["총결제금액"]),
                                      dr["고객명"].ToString(),
                                      dr["담당자"].ToString());
                    list.Add(receiptVo);

                    count++;
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
       
            dr.Close();
            return list;
        }

        public List<ReceiptVO> getReceiptVO()
        {
            string query = 
                "create or replace view receipt_view as " +
                "select receipt_id as 접수ID, " +
                "indate as 접수일, " +
                "total_price as 총결제금액, " +
                "(select customer_t.name from customer_t where " +
                "customer_t.cust_id = receipt_t.cust_id) as 고객명, " +
                "(select staff_t.name from staff_t where " +
                "staff_t.staff_id = receipt_t.staff_id) as 담당자, " +
                "(select car_t.num from car_t where " +
                "car_t.car_id = receipt_t.cust_id) as 차량번호 " +
                "from receipt_t";

            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            string query2 =
                "select * from receipt_view " +
                "order by 접수ID desc";
            cmd.CommandText = query2;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            int count = 1;
            List<ReceiptVO> list = new List<ReceiptVO>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ReceiptVO receiptVo =
                        new ReceiptVO(dr["접수일"].ToString(),
                                      Convert.ToInt32(dr["총결제금액"]),
                                      dr["고객명"].ToString(),
                                      dr["담당자"].ToString(),
                                      Convert.ToInt32(dr["접수ID"].ToString()),
                                      dr["차량번호"].ToString());
                    list.Add(receiptVo);
                    count++;
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }

            dr.Close();
            return list;
        }

        public List<ReceiptVO> getReceiptVoBySearch(
            string searchItem, string searchValue)
        {
            string query2 = string.Format(
                    "select * from receipt_view " +
                    "where {0} = '{1}'",
                    searchItem, searchValue);

            cmd.Connection = conn;
            cmd.CommandText = query2;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            int count = 1;
            List<ReceiptVO> list = new List<ReceiptVO>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ReceiptVO receiptVo =
                        new ReceiptVO(dr["indate"].ToString(),
                                      Convert.ToInt32(dr["total_price"]),
                                      dr["cust_name"].ToString(),
                                      dr["staff_name"].ToString(),
                                      Convert.ToInt32(
                                          dr["receipt_id"].ToString()),
                                      dr["car_num"].ToString());
                    list.Add(receiptVo);
                    count++;
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }

            dr.Close();
            return list;
        }

        public List<RepairItem> getRepairItem(string name)
        {

            string query2 = string.Format("select repair as 수리항목, " +
                            "price as 수리비 from REPAIR_ITEM_T " +
                            "where CAR_ID=" + 
                            "(select CUSTOMER_T.CUST_ID " +
                            "from customer_t " +
                            "where customer_t.Name='{0}')", name);

            cmd.CommandText = query2;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            int count = 1;

            List<RepairItem> list = new List<RepairItem>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine("번호: " + count);
                    Console.WriteLine("수리항목: " + dr["수리항목"]);
                    Console.WriteLine("수리비: " + dr["수리비"]);
                    Console.WriteLine("-----------------------");

                    list.Add(new RepairItem(0,
                                            dr["수리항목"].ToString(),
                                            Convert.ToInt32(dr["수리비"].ToString())
                                            ));
                    /*RepairItem repairItem =
                        new RepairItem(Convert.ToInt32(dr["번호"]),
                                    dr["수리항목"].ToString(),
                                    Convert.ToInt32(dr["수리비"]));*/

                    //list.Add(repairItem);
                    count++;      
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }

            dr.Close();
            return list;
        }
    }
}
