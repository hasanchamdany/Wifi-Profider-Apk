using System.Data;
using System;
using MySql.Data.MySqlClient;

namespace Wifi_Profider_Apk{
    public class User
    {
            string NIK;
            string alamat;
            string IP;
            string nama;
            string Username;
            string Password;
            bool statusPembayaran = false;
            string paket1 = "Paket 100 Mb/s";
            string paket2 = "Paket 50 Mb/s";
            string paket3 = "Paket 10 Mb/s";
            string jenis_paket;
            bool condition = true;
            string tanggal_bayar;
            string bulan_bayar;
            string tahun_bayar;
            static string connectionString = "server=localhost; port=3306; uid=hasan;" +
                                        "pwd=hasan; database=mywifi_database; charset=utf8; sslmode=none;";
            static MySqlConnection connection = new MySqlConnection(connectionString);


        public void AccountRegister()
        {
            
            // MySqlCommand command = connection.CreateCommand();
            // command.CommandType = System.Data.CommandType.Text;
            // command.CommandText = "Insert Into tbuser(dusername, dpassword, dfullname, dNIK) Values('"+Username+"', '"+Password+"', '"+nama+"', '"+NIK+"')";
            

            Console.WriteLine("Masukkan Nama Lengkap: ");
            nama = Console.ReadLine();
            Console.WriteLine("Masukkan NIK: ");
            NIK = Console.ReadLine();
            Console.WriteLine("Set Username Anda = ");
            Username = Console.ReadLine();
            Console.WriteLine("Set Password Anda = ");
            Password = Console.ReadLine();

            connection data = new connection();
            data.connect.Open();
            MySqlCommand cmd = new MySqlCommand("Insert Into user(username, password, fullname, NIK) Values('"+Username+"', '"+Password+"', '"+nama+"', '"+NIK+"')",data.connect);
            int index = cmd.ExecuteNonQuery();
            if(index > 0)
            {
                cmd.Cancel();
                Console.WriteLine("Akun dengan username {0} dan password {1} telah berhasil di tambahkan", Username, Password);
            }cmd.Cancel()         ;
        }
        public void WifiRegister()
        {
            Console.WriteLine("Pilih Jenis Paket: (1/2/3)");
            Console.WriteLine("1. Paket 100 Mb/s");
            Console.WriteLine("2. Paket 50 Mb/s");
            Console.WriteLine("3. Paket 10 Mb/s");
            int pilih4 = Convert.ToInt32(Console.ReadLine());
            if(pilih4 == 1){
                jenis_paket = paket1;
                Console.WriteLine("Masukkan Alamat Pemasangan: ");
                alamat = Console.ReadLine();
                Console.WriteLine("Set IP Anda: ");
                IP = Console.ReadLine();
                payment();
                Console.WriteLine("Paket Wifi 100 Mb/s Akan di pasangkan dalam 24 jam di alamat anda.");
                Console.WriteLine("----Terima Kasih----");
            }else if(pilih4 == 2){
                jenis_paket = paket2;
                Console.WriteLine("Masukkan Alamat Pemasangan: ");
                alamat = Console.ReadLine();
                Console.WriteLine("Set IP Anda: ");
                IP = Console.ReadLine();
                payment();
                Console.WriteLine("Paket Wifi 50 Mb/s Akan di pasangkan dalam 24 jam di alamat anda.");
                Console.WriteLine("----Terima Kasih----");
            }else if(pilih4 == 3){
                jenis_paket = paket3;
                Console.WriteLine("Masukkan Alamat Pemasangan: ");
                alamat = Console.ReadLine();
                Console.WriteLine("Set IP Anda: ");
                IP = Console.ReadLine();
                payment();
                Console.WriteLine("Paket Wifi 10 Mb/s Akan di pasangkan dalam 24 jam di alamat anda.");
                Console.WriteLine("----Terima Kasih----");
            }else{
                Console.WriteLine("Error, Out of Option");
            }
            DateTime Time = DateTime.Now;
        }
        public void login()
        {
            Console.WriteLine("--Selamat Datang di halaman Login--");
            Console.WriteLine("Enter Username:");
            Username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            Password = Console.ReadLine();
        }
        DateTime waktu = DateTime.Now;
        public void payment()
        {   
            Cpayment status = new Cpayment(); 
            // string OVO;
            // string Gopay;
            string VirtualAccount;
            string Indomaret;

            
            //DateTime t1 = new DateTime.Now(waktu);
            TimeSpan Tagihan = new TimeSpan(30,0,0);

            string tanggal_bayar;
            string bulan_bayar;
            string tahun_bayar;

            string Nomor_OVO;
            string Nomor_Gopay;
            Console.WriteLine("Selamat datang di Halaman Pembayaran");
            Console.WriteLine("Pilih Metode Pembayaran:");
            Console.WriteLine("1. Internet Banking");
            Console.WriteLine("2. Indomaret");
            Console.WriteLine("3. Gopay");
            Console.WriteLine("4. OVO");
            int pilih5 = Convert.ToInt32(Console.ReadLine());
            switch(pilih5)
            {
                case 1:
                    Console.WriteLine("Virtual Account anda : ");
                    VirtualAccount = "435876349523"; // random number (dari bank)
                    Console.WriteLine(VirtualAccount);
                    Console.WriteLine("Segera Bayarkan sebelum 24 jam");
                    status.payment = true;
                    Console.WriteLine(waktu.ToString("dddd, dd MMMM yyyy"));
                    tanggal_bayar = waktu.Day.ToString("dd");
                    bulan_bayar = waktu.Month.ToString("MM");
                    tahun_bayar = waktu.Year.ToString("yyyy");
                    
                    break;
                case 2: 
                    Console.WriteLine("Kode Tagihan Pembayaran : ");
                    Indomaret = "3T69Y5B34ZI9"; // random number (dari Indomaret)
                    Console.WriteLine(Indomaret);
                    Console.WriteLine("Segera Bayarkan sebelum 24 jam");
                    status.payment = true;
                    Console.WriteLine(waktu.ToString("dddd, dd MMMM yyyy"));
                    tanggal_bayar = DateTime.Now.Day.ToString("dd");
                    bulan_bayar = DateTime.Now.Month.ToString("MM");
                    tahun_bayar = DateTime.Now.Year.ToString("yyyy");
                    break;
                case 3:
                    Console.WriteLine("Input Nomor Gopay anda : ");
                    // Dana = "Y9UJ79I";
                    // Console.WriteLine(Dana);\
                    Nomor_Gopay = Console.ReadLine();
                    Console.WriteLine("Segera Accept Pembayaran Tagihan melalui akun OVO Anda");
                    status.payment = true;
                    Console.WriteLine(waktu.ToString("dddd, dd MMMM yyyy"));
                    tanggal_bayar = DateTime.Now.Day.ToString("dd");
                    bulan_bayar = DateTime.Now.Month.ToString("MM");
                    tahun_bayar = DateTime.Now.Year.ToString("yyyy");
                    break;
                case 4:
                    Console.WriteLine("Imput Nomor OVO anda : ");
                    // Ovo = "Y9UJ73429I";
                    // Console.WriteLine(Ovo);
                    Nomor_OVO = Console.ReadLine();
                    Console.WriteLine("Segera Accept Pembayaran Tagihan melalui akun OVO Anda");
                    status.payment = true;
                    Console.WriteLine(waktu.ToString("dddd, dd MMMM yyyy"));
                    tanggal_bayar = DateTime.Now.Day.ToString("dd");
                    bulan_bayar = DateTime.Now.Month.ToString("MM");
                    tahun_bayar = DateTime.Now.Year.ToString("yyyy");
                    break;
                }
        }
        /*public void deadline(){
            date Date = new date();
            Cpayment status = new Cpayment();
            Date.setdeadline();
            Console.WriteLine("Tanggal tenggat tagihan bulanan berikutnya = "+Date.deadline);
        }*/
        public void status()
        {
            date Date = new date();
            // billing tagihan = new billing();
            Console.WriteLine("--Selamat Datang di halaaman Status/info--");
            Console.WriteLine("username : {0} \nIP : {1} \nJenis Paket : {2}", Username, IP, jenis_paket);
            Console.WriteLine("Status Paket langganan Anda :");

            Cpayment status = new Cpayment();
            status.cekpayment();
            if(status.payment == true)
            {   //if(DateTime.Now.Day >= 20)
                //{
                Console.WriteLine("Anda sudah membayar Tagihan bulan ini pada tanggal:");
                Console.WriteLine(waktu);
                //Console.WriteLine("{0} / {1} / {2}", tanggal_bayar, bulan_bayar, tahun_bayar);    
                //}
            }
            else if(status.payment == false)
            {
                Console.WriteLine("Segera Bayar Tagihan Anda");
                Console.WriteLine("Tanggal tenggat tagihan bulanan = "+Date.deadline);
            }
        }
        public void customer_services()
        {
            Console.WriteLine("--Selamat datang di Halaman Layanan Pelanggan--");
            Console.WriteLine("Tuliskan Masalah Anda :");
            string trouble = Console.ReadLine();
            Console.WriteLine("Permasalahan Anda sudah masuk dan akan Dibalas dalam 24 jam ke depan \n --Terima Kasih--");
        }
        public void menu()
        {
            while(condition)
            {
                Console.WriteLine("###############################");
                Console.WriteLine("--Selamat Datang di Main Menu--");
                Console.WriteLine("###############################");
                Console.WriteLine("1. Status");
                Console.WriteLine("2. Pembyaran");
                Console.WriteLine("3. Layanan Pelanggan");
                Console.WriteLine("4. Log Out/Quit");
                int pilih6 = Convert.ToInt32(Console.ReadLine());
                if(pilih6 == 1)
                {
                    // data mydata_ = new data();
                    // mydata_.cek_data();
                    status();
                } else if(pilih6 == 2)
                {
                    payment();
                } else if(pilih6 == 3)
                {
                    customer_services();
                }else if(pilih6 == 4)
                {
                    condition = false;
                }
            }
        }

        }
    }