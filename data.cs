using System;
namespace WifiProfiderApk
{
    interface Data
    {
        public void cek_data();
    }
    class data : Data
    {
        public void cek_data()
        {
            User user = new User();
            user.status();
        }
        
    }
}