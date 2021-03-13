using System;
namespace WifiProfiderApk{
    public class Program{

        public string Username;
        public string Password;

        static void Main(string[] args){
            Console.WriteLine("---Selamat Datang di Wifi-Profider Apk---");
            Console.WriteLine("Apakah Anda memiliki Akun ? (yes/no)");
            string pilih1 = Console.ReadLine();
            User user = new User();
            if(pilih1 == "yes"){
                 user.login();
                 // Lanjut ke Tagihan (payment)
                 user.payment();
            }else if(pilih1 == "no"){
                 Console.WriteLine("Ingin Mendaftar? (yes/no)");
                 string pilih2 = Console.ReadLine();
                 if(pilih2 == "yes"){
                     //Register
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