/* Rose Silletto
 * IGME 202
 * Unit Test 2 #4-7
 * Oct. 23 2022
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test_2_7
{
    internal class Program
    {
        public abstract class Phone
        {
            private string phoneNumber;
            public string address;
            public string PhoneNumber 
            {
                get { return phoneNumber; }
                set { phoneNumber = value; }
            }
            public abstract void Connect();
            public abstract void Disconnect();
        }
        public interface PhoneInterface
        {
            void Answer();
            void MakeCall();
            void HangUp();
        }
        public class RotaryPhone : Phone, PhoneInterface
        {
            public void Answer() { }
            public void MakeCall() { }
            public void HangUp() { }
            public override void Connect() { }
            public override void Disconnect() { }
        }
        public class Tardis : RotaryPhone
        {
            private bool sonicScrewdriver;
            private byte whichDrWho;
            private string femaleSidekick;
            public double exteriorSurfaceArea;
            public double interiorSurfaceArea;
            public byte WhichDrWho
            {
                get { return WhichDrWho; }
            }
            public string FemaleSidekick
            {
                get { return FemaleSidekick; }
            }
            public void TimeTravel() { }

            public static Tardis operator ==(Tardis op1, Tardis op2)
            {
                Tardis returnVal = new Tardis();
                returnVal.whichDrWho = op1.whichDrWho == op2.whichDrWho;
                return returnVal;
            }

            public static Tardis operator !=(Tardis op1, Tardis op2)
            {
                Tardis returnVal = new Tardis();
                returnVal.whichDrWho = op1.whichDrWho != op2.whichDrWho;
                return returnVal;
            }

        }
        public class PushButtonPhone : Phone, PhoneInterface
        {
            public void Answer() { }
            public void MakeCall() { }
            public void HangUp() { }
            public override void Connect() { }
            public override void Disconnect() { }
        }
        public class PhoneBooth : PushButtonPhone
        {
            private bool superMan;
            public double costPerCall;
            public bool phoneBook;
            public void OpenDoor() { }
            public void CloseDoor() { }
        }

        static void UsePhone(object obj)
        {
            PhoneInterface.MakeCall();
            PhoneInterface.HangUp();

            if (obj == PhoneBooth) {
                PhoneBooth.OpenDoor();
            }
            else if ( obj == Tardis) {
                Tardis.TimeTravel();
            }

        }

        static void Main(string[] args)
        {
            Tardis tardis = new Tardis();
            PhoneBooth phoneBooth = new PhoneBooth();

            UsePhone(tardis);
            UsePhone(phoneBooth);

        }
    }

}
