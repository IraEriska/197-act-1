using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Conecteed
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConnectionString = GetConnectionString();
            string query1 = "select * from Pembimbing_Akademik where NIK=333";
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd1 = new SqlCommand(query1, cn); cn.Open();
                using (SqlDataReader dr1 = cmd1.ExecuteReader())
                {
                    while (dr1.Read())
                    {
                        string query2 = "UPDATE Pembimbing_Akademik SET Keahlian = 'Jaringan' WHERE NIK = 333";
                        SqlCommand cmd2 = new SqlCommand(query2, cn);
                        cmd2.ExecuteNonQuery();
                        Console.WriteLine("Data has been updated");
                    }

                }
            }
            Console.ReadLine();
        }
        private static string GetConnectionString()
        {
            return "data source = LAPTOP-K1JU7IK4;database=ProdiTI;MultipleActiveResultSets=True;User ID=sa;Password =Eref26042001";
        }
    }
}
