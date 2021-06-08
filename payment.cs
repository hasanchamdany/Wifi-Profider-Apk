namespace Wifi_Profider_Apk
{
    public class Cpayment
    {
        private bool _payment;
        public bool payment{
            get{return _payment;}
            set{_payment = value;}
        }
        public void cekpayment(){
            date Date = new date();
            if(Date.today.Month == Date.deadline.Month){
                payment = true;
            }else{
                payment = false;
            }
        }
    }
}