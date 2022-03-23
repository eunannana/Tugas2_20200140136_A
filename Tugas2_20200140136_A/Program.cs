using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tugas2_20200140136_A
{
    public class Program
    {
        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source =ANN\\ANNSANDRYN; database=KontrakTenantMall;Integrated Security = TRUE");
                con.Open();

                Console.WriteLine("Successfully connected to Database!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops, Failed connected to Database... " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
        static void Main(string[] args)
        {
            new Program().InsertData();
        }
    }
}
