using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create an array of few instances of the GSM class.
//Display the information about the GSMs in the array.
//Display the information about the static property IPhone4S
namespace DefineClass
{
    class GSMTest
    {
        static void Main(string[] args)
        {
            GSM[] phones = {
                               new GSM("Nexus", "Samsung",350,null,new Battery("Lion",8,4,BatteryType.NiMH),new Display(5,40000000)),
                               new GSM("G3","LG"),
                               new GSM("Iphone4","Apple")
                           };
            foreach (var phone in phones)
            {
                Console.WriteLine(phone);
            }
            Console.WriteLine(GSM.iPhone4S);
            GSMCallHistoryTest a = new GSMCallHistoryTest();
            a.CallHistoryTest();
        }
    }
}
