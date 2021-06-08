using System;
using MySql.Data.MySqlClient;
namespace Wifi_Profider_Apk{

public class connection
{
    private static string connectionString = "server=localhost; port=3306; uid=hasan;" +
                                        "pwd=hasan; database=test; charset=utf8; sslmode=none;";
    private MySqlConnection _connection = new MySqlConnection(connectionString);
    public MySqlConnection connect{
        get{return _connection;}
    }
}
}