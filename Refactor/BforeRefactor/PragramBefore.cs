using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor
{
    class PragramBefore
    {
        private static void MainBefore(string[] args)
        {
            string a;
            string b;
            string c;
            string d;
            Console.WriteLine("enter userName:");
            a = Console.ReadLine();
            Console.WriteLine("enter firstName:");
            b = Console.ReadLine();
            Console.WriteLine("enter LastName:");
            c = Console.ReadLine();
            Console.WriteLine("enter Password:");
            d = Console.ReadLine();
            if (a.Length == 0)
                throw new Exception("خطا");
            if (b.Length == 0)
                throw new Exception("خطا");
            if (c.Length == 0)
                throw new Exception("خطا");




            if (ISPasswordValid(d) == false)
            {
                throw new Exception("خطا");
            }
            SqlConnection con = new SqlConnection("");

            SqlCommand com = new SqlCommand($"insert into users values({a},{b},{c},{d})", con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

            File.WriteAllText("", $"{a},{b},{c},{d}");

        }

        private static bool ISPasswordValid(string password)
        {
            if (password.Length == 0)
                return false;
            if (password.Length < 8)
                return false;
            //check password has any character like !@#$%
            bool g = false;

            for (int i = 0; i < password.Length; i++)
            {

                if (password[i] == '@')
                    g = true;
                if (password[i] == '!')
                    g = true;
                if (password[i] == '#')
                    g = true;
                if (password[i] == '$')
                    g = true;
                if (password[i] == '%')
                    g = true;

            }

            return g;
        }
    }
}
