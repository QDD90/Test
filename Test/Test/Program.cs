using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeStamp;
using HelperLib;
using LogHelper;

namespace Test
{
    public class Program
    {
       public  static void Main(string[] args)
        {
            //string LogTxt = string.Format("{0}/{1}/{2}.log", "D:/Log", DateTime.Now.ToString("yyyy-MM"), DateTime.Now.ToString("yyyyMMdd"));
            //Log.WriteLog(LogTxt,"目录建立成功");
            //HelperLib.LogHelper log = new LogHelper();
            //log.DBWrite("", "", "", 1);
            //TimeStamp.DateAndTimeFormat dateAndTimeFormat=new DateAndTimeFormat();
            string str =DateAndTimeFormat.TimeNowToMillisecond();
            string str1 = DateAndTimeFormat.HourAdd(str,2);
            DateTime dt = parseDate(str);
            //string str2 = DateTime.Now.AddHours(25).ToString();
            Console.WriteLine("当前时间：" + dt);
            Console.ReadLine();
        }
        public static string TimeNow()
        {
            return DateTime.Now.ToString();
        }
        public static string DateString()
        {
            return DateTime.Now.ToString().Replace("/", "-");
        }
        public static DateTime parseDate(string date)
        {
            //IFormatProvider culture = new System.Globalization.CultureInfo("zh-CN", true);
            //string[] expectedFormats = { "yyyy-MM-dd HH:mm:ss", "yyyy-MM-d HH:mm:ss", "yyyy-M-dd HH:mm:ss", "yyyy-M-dd HH:mm:ss" };
            //DateTime dateTime = DateTime.ParseExact(date, expectedFormats, culture, System.Globalization.DateTimeStyles.AllowInnerWhite);

            DateTime dateTime = DateTime.Parse(date);
            return dateTime;
        }
        //public static int Date_cmp(string str1, string str2)
        //{
        //    //DateTime date1 = Tool.parseDate("2005-6-07 12:23:34");
        //    //DateTime date2 = Tool.parseDate("2005-07-07 12:23:34");
        //    //return -1

        //    if (str2.Equals("0000-00-00 00:00:00")) return 1;
        //    DateTime date1 = Tool.parseDate(str1);
        //    DateTime date2 = Tool.parseDate(str2);

        //    return DateTime.Compare(date1, date2);
        //}
    }
}
