using System;
namespace WifiProfiderApk{
    public class User
    {
            string NIK;
            string alamat;
            string IP;
            string nama;
            string Username;
            string Password;

        public void AccountRegister()
        {
            Console.WriteLine("Masukkan Nama Lengkap: ");
            nama = Console.ReadLine();
            Console.WriteLine("Masukkan NIK: ");
            NIK = Console.ReadLine();
            Console.WriteLine("Set Username Anda = ");
            Username = Console.ReadLine();
            Console.WriteLine("Set Password Anda = ");
            Password = Console.ReadLine();
        }
        public void WifiRegister()
        {
            Console.WriteLine("Pilih Jenis Paket: (1/2/3)");
            Console.WriteLine("1. Paket 100 Mb/s");
            Console.WriteLine("2. Paket 50 Mb/s");
            Console.WriteLine("3. Paket 10 Mb/s");
            int pilih4 = Convert.ToInt32(Console.ReadLine());
            if(pilih4 == 1){
                Console.WriteLine("Masukkan Alamat Pemasangan: ");
                alamat = Console.ReadLine();
                Console.WriteLine("Set IP Anda: ");
                IP = Console.ReadLine();
                Console.WriteLine("Paket Wifi 100 Mb/s Akan di pasangkan dalam 24 jam di alamat anda.");
                Console.WriteLine("----Terima Kasih----");
            }else if(pilih4 == 2){
                Console.WriteLine("Masukkan Alamat Pemasangan: ");
                alamat = Console.ReadLine();
                Console.WriteLine("Set IP Anda: ");
                IP = Console.ReadLine();
                Console.WriteLine("Paket Wifi 50 Mb/s Akan di pasangkan dalam 24 jam di alamat anda.");
                Console.WriteLine("----Terima Kasih----");
            }else if(pilih4 == 3){
                Console.WriteLine("Masukkan Alamat Pemasangan: ");
                alamat = Console.ReadLine();
                Console.WriteLine("Set IP Anda: ");
                IP = Console.ReadLine();
                Console.WriteLine("Paket Wifi 10 Mb/s Akan di pasangkan dalam 24 jam di alamat anda.");
                Console.WriteLine("----Terima Kasih----");
            }else{
                Console.WriteLine("Error, Out of Option");
            }
        }
        public void login()
        {
            Console.WriteLine("Enter Username:");
            Username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            Password = Console.ReadLine();
        }
        public void payment()
        {   
            string Ovo;
            string Dana;
            string VirtualAccount;
            string Indomaret;

            Console.WriteLine("Selamat datang di Halaman Pembayaran");
            Console.WriteLine("Pilih Metode Pembayaran:");
            Console.WriteLine("1. Internet Banking");
            Console.WriteLine("2. Indomaret");
            Console.WriteLine("3. Dana");
            Console.WriteLine("4. Ovo");
            int pilih5 = Convert.ToInt32(Console.ReadLine());
            switch(pilih5)
            {
                case 1:
                    Console.WriteLine("Virtual Account anda : ");
                    VirtualAccount = "435876349523"; // random number (dari bank)
                    Console.WriteLine(VirtualAccount);
                    Console.WriteLine("Segera Bayarkan sebelum 24 jam");
                    break;
                case 2: 
                    Console.WriteLine("Nomor Pembayaran : ");
                    Indomaret = "346985348923"; // random number (dari Indomaret)
                    Console.WriteLine(Indomaret);
                    Console.WriteLine("Segera Bayarkan sebelum 24 jam");
                    break;
                case 3:
                    Console.WriteLine("Kode Pembayaran DANA : ");
                    Dana = "Y9UJ79I";
                    Console.WriteLine(Dana);
                    Console.WriteLine("Segera Bayarkan sebelum 24 jam");
                    break;
                case 4:
                    Console.WriteLine("Kode Pembayaran DANA : ");
                    Ovo = "Y9UJ73429I";
                    Console.WriteLine(Ovo);
                    Console.WriteLine("Segera Bayarkan sebelum 24 jam");
                    break;
                }
            }
        }
    }