using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
    //Create a class Call to hold a call performed through a GSM.
    //It should contain date, time, dialled phone number and duration (in seconds).
    public class Call
    {
        private string date;
        private string time;
        private string dialed;
        private long duration;

        public Call(string date, string time, string dialed, long duration)
        {
            this.Date = date;
            this.Time = time;
            this.Dialed = dialed;
            this.Duration = duration;
        }
        public override string ToString()
        {
            //     private string model;
            //private string manufacturer;
            //private double? price;
            //private string? owner;
            //private Battery? phoneBat;
            //private Display? phoneDisp;
            return "Date:" + Date + ",time:" + Time + ",dialed:" + Dialed + ", Duration:" + Duration;
        }
        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public string Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }
        public string Dialed
        {
            get
            {
                return dialed;
            }
            set
            {
                dialed = value;
            }
        }
        public long Duration
        {
            get
            {
                return duration;
            }
            set
            {
                try
                {
                    duration = value;
                }
                catch (Exception me)
                {
                    Console.WriteLine(me.Message); ;
                }
            }
        }
    }
}
