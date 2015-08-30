using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
    public enum BatteryType
        { Li_Ion, NiMH, NiCd, SuperBattery };

    public class Battery
    {
        
        //model, hours idle and hours talk
        private string model;
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryType? batType;

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public double? HoursIdle
        {
            get
            {
                return hoursIdle;
            }
            set
            {
                try
                {
                    hoursIdle = value;
                }
                catch (Exception me)
                {
                    Console.WriteLine(me.Message);
                }
            }
        }
        public double? HoursTalk 
        {
            get 
            {
                return hoursTalk;
            }
            set
            {
                try
                {
                    hoursTalk = value;
                }
                catch (Exception me)
                {
                    Console.WriteLine(me.Message); ;
                }
            }
        }
        public BatteryType? BatType
        {
            get
            {
                return batType;
            }
            set
            {
                try
                {
                    batType = value;
                }
                catch (Exception me)
                {
                    Console.WriteLine(me.Message); ;
                }
            }
        }
        public Battery()
        {
            this.model = null;
            this.hoursIdle = null;
            this.hoursTalk = null;
        }
        public Battery(string model, double? idle, double? talk,BatteryType? type)
        {
            this.model = model;
            this.hoursIdle = idle;
            this.hoursTalk = talk;
            this.batType = type;
        }
    }
}
