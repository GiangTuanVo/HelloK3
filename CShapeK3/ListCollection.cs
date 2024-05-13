//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HelloK3
//{
//    class PlcConnection //TCP/I
//    {
//        public string IPAddress { get; set; }
//        public int Port { get; set; }
//    }

//    class ListCollection
//    {
//        private static List<int> GetListRandom(int length)
//        {
//            Random random = new Random();
//            List<int> list = new List<int>();
//            for (int i = 0; i < length; i++)
//            {
//                list.Add(random.Next(0, 100));
//            }
//            return list;
//        }
//        static void Main(string[] args)
//        {
//            //Cấp phát bộ nhớ động nên không cần khái báo chiều dài
//            //List<int> listNumber;//Khai báo ->string, double
//            //listNumber = new List<int>();// Khơi tạo 

//            //listNumber.Add(1);
//            //listNumber.Add(2);

//            //listNumber.Remove(3); //truyền vào object
//            //listNumber.RemoveAt(1); // index
//            //listNumber.Clear(); //Xoá hết

//            //List<PlcConnection> plcConnections = new List<PlcConnection>();

//            //PlcConnection PLC1 = new PlcConnection();
//            //PLC1.IPAddress = "192.168.0.1";
//            //PLC1.Port = 1000;

//            //PlcConnection PLC2 = new PlcConnection();
//            //PLC2.IPAddress = "192.168.0.2";
//            //PLC2.Port = 5000;

//            //plcConnections.Add(PLC1);
//            //plcConnections.Add(PLC2);

//            //foreach (PlcConnection item in plcConnections)
//            //{
//            //    Console.WriteLine("Address: {0}, Port: {1}", item.IPAddress, item.Port);
//            //}
//            List<int> ret = GetListRandom(10);
//            bool checkContain = ret.Contains(10);
//            int checkIndexof = ret.IndexOf(25);

//            //ret.Insert(2, 10);// chèn vào list
//            List<int> insert = new List<int>() { 23, 12, 24 };//colection
//            ret.InsertRange(2, insert);
//            ret.RemoveRange(2, 3);
//            //Sắp xếp
//            ret.Sort();
//            ret.Reverse();
            
//            //ArrayList

//            List<int> newList = ret.GetRange(0, 5);

//            Console.ReadKey();
//        }
//    }
//}
