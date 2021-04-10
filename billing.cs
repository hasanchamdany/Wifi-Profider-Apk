using System;
namespace WifiProfiderApk{
    public class billing{
        
        string tanggal;
        string bulan;
        string tahun;
        public void waktu(){
            tanggal = DateTime.Now.Day.ToString("00");
            bulan = DateTime.Now.Month.ToString("00");
            tahun = DateTime.Now.Year.ToString("0000");
        }
    }
}