using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShopForm
{
    public class Peripheral
    {
     
        public enum WiredOrWireless 
        { 
            Unknown = 0,
            Wired = 1, 
            Wireless = 2
        }

        public enum UsbConnection 
        { 
            Unknown = 0,
            USB_A = 1,
            USB_B = 2,
            USB_C = 3,
            USB_microB = 4,
            USBmini = 5
        }
        public enum KeyboardType 
        {
            Unknown = 0,
            Normal = 1,
            Mechanical = 2,
            Compact = 3
        }

        public enum KeyboardLayout
        {
            Unknown = 0,
            Azerty = 1,
            Qwerty = 2            
        }
        public enum ScreenPanel
        {
            Unknown = 0,
            Tn = 1,
            Oled = 2,
            Ips = 3
        }


    }
}
