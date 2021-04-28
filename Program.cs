using System;
using MySql.Data.MySqlClient;

namespace WifiProfiderApk{
    public class Program{

        public string Username;
        public string Password;
        
        static string connectionString = "server=localhost; port=3306; uid=hasan;" +
                                        "pwd=hasan; database=mywifi_database; charset=utf8; sslmode=none;";
        
        static MySqlConnection connection = new MySqlConnection(connectionString);
        static void Main(string[] args){

            Console.WriteLine("Connecting to MySql DB");

            using(connection)
            {
                try{
                    connection.Open();
                    
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

                    connection.Close();
                }catch(MySql.Data.MySqlClient.MySqlException ex){
                    System.Console.WriteLine("Error: " + ex.Message.ToString());
                }
                
            }
            
           

        }
    }
}