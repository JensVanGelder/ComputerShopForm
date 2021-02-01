using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ComputerShopForm.Peripheral;

namespace ComputerShopForm
{  
    class Peripherals : Product
    {        
        public WiredOrWireless WiredOrWireless { get; set; }

        public UsbConnection UsbConnection { get; set; }

        public Peripherals(int id, string name, double price, string imagepath, string summary, int stock, WiredOrWireless wiredOrWireless, UsbConnection usbConnection) 
            : base (id, name, price, imagepath, summary, stock)
        {
            WiredOrWireless = wiredOrWireless;
            UsbConnection = usbConnection;
        }

        public override string ToString()
        {
            WiredOrWireless wiredOrWireless = WiredOrWireless;
            UsbConnection usbConnection = UsbConnection;
            string add = $"Is {wiredOrWireless} and has an {usbConnection} USB-connection";

            return base.ToString() + add;
        }
    }
}
