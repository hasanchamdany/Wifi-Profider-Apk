using System;
namespace WifiProfiderApk{
    public class User{
            string NIK;
            string alamat;
            string IP;
            string nama;
            string Username;
            string Password;

        public void AccountRegister(){
            Console.WriteLine("Masukkan Nama Lengkap: ");
            nama = Console.ReadLine();
            Console.WriteLine("Masukkan NIK: ");
            NIK = Console.ReadLine();
            Console.WriteLine("Set Username Anda = ");
            Username = Console.ReadLine();
            Console.WriteLine("Set Password Anda = ");
            Password = Console.ReadLine();
        }
        public void WifiRegister(){
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
        public void login(){
            Console.WriteLine("Enter Username:");
            Username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            Password = Console.ReadLine();
        }
    }
}