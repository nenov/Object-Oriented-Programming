using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
//Create an instance of the GSM class.
//Add few calls.
//Display the information about the calls.
//Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
//Remove the longest call from the history and calculate the total price again.
//Finally clear the call history and print it
    public class GSMCallHistoryTest
    {
        public void CallHistoryTest()
        {
            GSM myPhone = new GSM("Lumia", "Nokia");
                    //public Call(string date, string time, string dialed, long duration)
            List<Call> someCalls =new List<Call> {
            new Call("02.02.2015", "15:45", "0896232333", 56),
            new Call("03.18.2015", "11:45", "0852454555", 13),
            new Call("01.02.2015", "00:05", "0899656598", 118),
            new Call("03.15.2015", "18:32", "0896232333", 65)};
            foreach (Call a in someCalls)
            { myPhone.AddCall(a); }
            myPhone.DisplayCalls();
            double price = 0.37;
            Console.WriteLine("With price of 0.37 per minute, the total cost of the calls:" + myPhone.CalcPrice(price/60));
            Console.WriteLine("Removing the longest call ...");
            myPhone.DeleteCall(someCalls[2]);
            Console.WriteLine("With price of 0.37 per minute, the total cost of the calls:" + myPhone.CalcPrice(price / 60));
            myPhone.ClearHistory();
            Console.WriteLine("History Cleared");
            Console.WriteLine("Current History:");
            myPhone.DisplayCalls();

        }        
    }
}
