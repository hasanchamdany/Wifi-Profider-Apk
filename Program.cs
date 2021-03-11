using System.Reflection.Metadata;
using System;
namespace WifiProfiderApk{
    public class Program{

        public string username;
        public string Password;

        static void Main(string[] args){
            Console.WriteLine("---Selamat Datang di Wifi-Profider Apk---");
            Console.WriteLine("Apakah Anda memiliki Akun ? (yes/no)");
            string pilih1 = Console.ReadLine();
            if(pilih1 == "yes"){
                 Console.WriteLine("Enter Username:");
                 username = Console.ReadLine();
                 Console.WriteLine("Enter Password:");
                 Password = Console.ReadLine();
                 // Lanjut ke Tagihan (payment)
            }else if(pilih1 == "no"){
                 Console.WriteLine("Ingin Mendaftar? (yes/no)");
                 string pilih2 = Console.ReadLine();
                 if(pilih2 == "yes"){
                     //Register
                     User user = new User();
                     user.AccountRegister();
                     Console.WriteLine("Apakah Ingin Berlangganan ? (yes/no)");
                     string pilih3 = Console.ReadLine();
                     if(pilih3 == "yes"){
                        user.WifiRegister();
                     }
                 }
            }else {
                Console.WriteLine("Error, Tidak ada Inputan Selain yes/no");
            }
           

        }
    }
}