using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Koneksi
{
    class Program
    {

        static void Main(string[] args)
        {
            new Program().InsertData();
        }
        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source = IHSAN\\MUHAMMADIHSAN; database = IHSAN_EXE12; User ID = sa; Password = 123");
                con.Open();

                SqlCommand cm = new SqlCommand("INSERT INTO Client (ClientId, ClientNo, Nama, Umur, Pekerjaan, Alamat, Telp) VALUES ('ID01','CO1','Agus','30','Dokter','bantul','813924982')" +
                    "INSERT INTO Client (ClientId, ClientNo, Nama, Umur, Pekerjaan, Alamat, Telp) VALUES ('ID02','CO2','Bambang','31','Dosen','bantul','813924932')" + "INSERT INTO Client " +
                    "(ClientId, ClientNo, Nama, Umur, Pekerjaan, Alamat, Telp) VALUES ('ID03','CO3','Rohmat','32','Pilot','bantul','813925983')" + "INSERT INTO Client (ClientId, ClientNo, Nama," +
                    " Umur, Pekerjaan, Alamat, Telp) VALUES ('ID04','CO4','Firaun','33','Guru','bantul','813924934')" + "INSERT INTO Client (ClientId, ClientNo, Nama, Umur, Pekerjaan, Alamat, Telp) VALUES ('ID05','CO5','Ahmad','34','Supir','bantul','813925953')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data, " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
