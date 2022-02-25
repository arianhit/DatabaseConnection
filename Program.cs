using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;

namespace Performance
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con;
            string str;
            //string courseName;
            //int courseTotalHours;
            //int courseId;
            try
            {
                str= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= G:\My Drive\University Sheffieeld Hallam\Y1\Software Project\Performance\Performance\ERDTabales.mdf ;Integrated Security=True";
                con = new SqlConnection(str);
                con.Open();
                Console.WriteLine("Database Connected");

                //Console.WriteLine("\n Enter Your Course id");
                //courseId = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("\n Enter Your Course name");
                //courseName = Console.ReadLine();
                //Console.WriteLine("\n Enter Your Course total hours");
                //courseTotalHours = Convert.ToInt32(Console.ReadLine());
                //string queryInsert = "INSERT INTO Course (Course_Id,Course_Name,Course_Total_Hours) VALUES (" + courseId + ",'" + courseName + "'," + courseTotalHours + ") ";

                //SqlCommand ins = new SqlCommand(queryInsert, con);
                //ins.ExecuteNonQuery();

                //Console.WriteLine("\n Data Stored Into Database");

                //string queryRead = "SELECT * FROM Course";
                //SqlCommand read = new SqlCommand(queryRead, con);
                //SqlDataReader dtreader = read.ExecuteReader();
                //while(dtreader.Read())
                //{
                //    Console.WriteLine("\n Course name :" + dtreader.GetValue(1).ToString());
                //    Console.WriteLine("\n Course Total hours :" + dtreader.GetValue(2).ToString());
                //}
            } 
            catch (SqlException x)
            {
                Console.WriteLine(x.Message);
            }
            Console.ReadLine();
        }
    }
}
