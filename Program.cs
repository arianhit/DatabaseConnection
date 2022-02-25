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
            //we need an sql connection variable
            SqlConnection con;
            //we need the database address as an string
            string str;


            try
            {
                //database address
                str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= G:\My Drive\University Sheffieeld Hallam\Y1\Software Project\Performance\Performance\ERDTabales.mdf ;Integrated Security=True";

                //creating connection with the database address
                con = new SqlConnection(str);

                //open connection
                con.Open();
                //writing a massage that databas is connected
                Console.WriteLine("Database Connected");

            }
            catch (SqlException x)
            {
                Console.WriteLine(x.Message);
            }
            
        }
    }
}
