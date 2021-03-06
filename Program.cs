using System;
using MySql.Data.MySqlClient;

namespace Wifi_Profider_Apk{
    public class Program{

        public string Username;
        public string Password;
        
        static void Main(string[] args){
            connection data = new connection();

            Console.WriteLine("Connecting to MySql DB");

            using(data.connect)
            {
                try{
                    data.connect.Open();
                    
                    Console.WriteLine("---Selamat Datang di Wifi-Profider Apk---");
                    Console.WriteLine("Apakah Anda memiliki Akun ? (yes/no)");
                    string pilih1 = Console.ReadLine();
                    User user = new User();
                    if(pilih1 == "yes"){
                        user.login();
                        user. menu();
                    }else if(pilih1 == "no"){
                        Console.WriteLine("Ingin Mendaftar? (yes/no)");
                        string pilih2 = Console.ReadLine();
                        if(pilih2 == "yes"){
                            //Register
                            user.AccountRegister();
                            user.login();
                            Console.WriteLine("Apakah Ingin Berlangganan ? (yes/no)");
                            string pilih3 = Console.ReadLine();
                            if(pilih3 == "yes"){
                                user.WifiRegister();
                                user.menu();
                            }
                        }
                    }else {
                        Console.WriteLine("Error, Tidak ada Inputan Selain yes/no");
                    }

                    data.connect.Close();
                }catch(MySql.Data.MySqlClient.MySqlException ex){
                    System.Console.WriteLine("Error: " + ex.Message.ToString());
                }
                
            }
            
           

        }
    }
}