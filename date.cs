using System;
namespace Wifi_Profider_Apk
{
    public class date
    {
        private DateTime _today;
        private DateTime _deadline;
        public DateTime today{
            get{return _today;}
            set{_today = value;}
        }
        public DateTime deadline{
            get{return _deadline;}
            set{_deadline = value;}
        }
        public void setdate(){
            today = DateTime.Now;
        }
        /*
        public void setdeadline(){
            Cpayment status = new Cpayment();
            deadline.Date = 20;
            if(status.payment == true){
                deadline.Month = today.AddMonths(1);
                status.payment = false;
            }
            else{
                deadline.Month = today.Month;
            }
            
        }
        */
    }
}