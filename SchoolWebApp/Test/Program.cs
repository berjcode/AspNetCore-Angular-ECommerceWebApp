using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace Test
{
    internal class Program
    {

       
        static void Main(string[] args)
        {

            
           

            string connectionString = "Data Source=(local);Initial Catalog=SchoolDb;Integrated Security=SSPI";

            // Veritabanından verileri okumak için kullanılacak sorgu
            string queryString = "exec GetStudent"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Öğrenci ID: " + reader["OGRID"] + " Öğrenci Adı: " + reader["OGRAD"] + " Öğrenci Soyadı: " + reader["OGRSOYAD"]);
                    }
                }
            }
            SaveData();
            Console.ReadLine();
            
          

        }




       public static void SaveData()
        {
           
            string connectionString = "Data Source=(local);Initial Catalog=SchoolDb;Integrated Security=SSPI";
            // Veri alma

            string OGRAD = "Ali";
            string OGRSOYAD = "BALIKÇI";
             string OGRFOTOGRAF = "adsda";

            string OGRTELEFON = "34343";
            string OGRMAIL = "abdblk2525@gmail.com";

            string OGRSIFRE = "12345";

            // Veritabanı bağlantısı oluşturma
          
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Veritabanına bağlanma
                conn.Open();

                // Veri ekleme sorgusu
                string sql = "INSERT INTO TBL_OGRENCI (OGRAD, OGRSOYAD,OGRFOTOGRAF,OGRTELEFON,OGRMAIL,OGRSIFRE) VALUES (@ograd, @ogrsoyad, @ogrfotograf,@ogrtelefon,@ogrmail, @ogrsifre)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ograd", OGRAD);
                cmd.Parameters.AddWithValue("@ogrsoyad", OGRSOYAD);
                cmd.Parameters.AddWithValue("@ogrfotograf", OGRFOTOGRAF);
                cmd.Parameters.AddWithValue("@ogrtelefon", OGRTELEFON);
                cmd.Parameters.AddWithValue("@ogrmail", OGRMAIL);
                cmd.Parameters.AddWithValue("@ogrsifre", OGRSIFRE);


                // Veri ekleme
                cmd.ExecuteNonQuery();

                // Bağlantı kapatma
                conn.Close();
            }

            // Başarılı sonuç mesajı
            Console.WriteLine("Veri Başarıyla Eklendi");
        }
    }
}

//dataview nesnesi nedir ? 

//DataView nesnesini Sql Server'da bulunan View nesneleri göz önüne alınarak oluşturulan bir sınıftır. Bilindiği gibi view'ler önceden derlenen nesneler 
//    oldukları için performansı çok yüksektir. Ado.Net tarafında da DataView nesneler performans ve hız açısından avantajlıdır.

//SQLInjection saldırısına uğramamak için parametreli çalış.


//Connected mimari sqldatareader()
//bağlantıyı manuel açığ kapatabiliyruz. sql reader sayesinde tabloyu satır satır okuyup işlem yapabiliyoruz.

//disconnected mimari : sqldataadapter

//bağlantı otomotik acılıp kapanır. insert update , delete otomoti koluşur. performans kaybı vardır.


//sqlcommands :bizim veritabanı üzerinde yapmak istediğimiz işlemlerin ADO tarafında belirtilmesini sağlayan sınıftır



//T DataSet, veri kaynağından bağımsız tutarlı bir ilişkisel programlama modeli sağlayan verilerin bellekte yerleşik bir gösterimidir
