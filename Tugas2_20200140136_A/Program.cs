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

                SqlCommand insert1 = new SqlCommand("insert into pemilik (ID_pemilik, nama_pemilik, noHP_pemilik, alamat_pemilik, email_pemilik, jenisKelamin_pemilik) values ('3320357720020001','Anna Gianna', '0812345678910', 'Jalan Bahagia Nomor 1 Yogyakarta', 'anna123@gmail.com','P')", con);
                insert1.ExecuteNonQuery();

                SqlCommand insert2 = new SqlCommand("insert into penyewa (ID_penyewa, nama_penyewa, noHP_penyewa, alamat_penyewa, email_penyewa, jenisKelamin_penyewa) values ('3319237081901982','Aan Adrian','0810987654321','Jalan Kenangan Nomor 2 Yogyakarta','aan321@gmail.com','L')", con);
                insert2.ExecuteNonQuery();

                SqlCommand insert3 = new SqlCommand("insert into tenant (ID_tenant, jenis_sewa, lama_sewa, harga_sewa, lokasi_tenant) values ('201','TAHUN','2',20000000,'Lantai 3 Blok F')", con);
                insert3.ExecuteNonQuery();

                Console.WriteLine("Successfully add data to Database!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops, Failed add data to Database... " + e);
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
