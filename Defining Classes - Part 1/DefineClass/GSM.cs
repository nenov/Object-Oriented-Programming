using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
    //model, manufacturer, price, owner, battery characteristics 
    //(model, hours idle and hours talk) and display characteristics (size and number of colors)
    //Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
    public class GSM
    {
        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private Battery phoneBat;
        private Display phoneDisp;
        private List<Call> CallHistory = new List<Call>();

        private static string IPhone4S = "the information about iPhone 4S";

        public static string iPhone4S
        {
            get
            {
                return IPhone4S;
            }
        }
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
        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                manufacturer = value;
            }
        }
        public double? Price
        {
            get
            {
                return price;
            }
            set 
            {
                try
                {
                    price = value;
                }
                catch (Exception me)
                {
                    Console.WriteLine(me.Message);
                }
            }
        }
        public string Owner
        {
            get
            {
                return owner;
            }
            set 
            {
                owner = value;
            }
        }
        public Battery PhoneBat
        {
            get
            {
                return phoneBat;
            }
            set
            {
                phoneBat = value;
            }
        }
        public Display PhoneDisp
        {
            get
            {
                return phoneDisp;
            }
            set
            {
                phoneDisp = value;
            }
        }
        
        public GSM(string model, string manufacturer, double? price, string owner, Battery bat, Display disp)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.phoneBat = bat;
            this.phoneDisp = disp;
        }
        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }
        public override string ToString()
        {
            string price = Price.ToString();
        //     private string model;
        //private string manufacturer;
        //private double? price;
        //private string? owner;
        //private Battery? phoneBat;
        //private Display? phoneDisp;
            return "Model:"+model + ",Manufacturer:" + manufacturer + ",Price:" + price + ", Owner:"+owner;
        }
        public void DisplayCalls()
        {
            foreach(Call a in CallHistory)
            { Console.WriteLine(a); }
        }
        public void AddCall(Call call)
        {
            CallHistory.Add(call);
        }
        public void DeleteCall(Call call)
        {
            int index = CallHistory.IndexOf(call);
            
            CallHistory.RemoveAt(index);
        }
        public void ClearHistory()
        {
            CallHistory.Clear();
        }
        public double CalcPrice(double pricePerMin)
        {
            double sum = 0;
            foreach( var cal in CallHistory)
            {
                sum = sum + cal.Duration * pricePerMin;
            }
            return sum;
        }
    }
}
