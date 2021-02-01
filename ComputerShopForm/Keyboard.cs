using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ComputerShopForm.Peripheral;

namespace ComputerShopForm
{
    class Keyboard : Peripherals
    {
        public KeyboardType KeyboardType { get; set; }

        public bool HasRgb { get; set; }

        public KeyboardLayout KeyboardLayout { get; set; }

        public Keyboard(int id, string name, double price, string imagepath, string summary, int stock, WiredOrWireless wiredOrWireless, UsbConnection usbConnection, KeyboardType keyboardType, bool hasrgb, KeyboardLayout keyboardLayout)
            : base(id, name, price, imagepath, summary, stock, wiredOrWireless, usbConnection)
        {
            KeyboardType = keyboardType;
            HasRgb = hasrgb;
            KeyboardLayout = keyboardLayout;
        }

        public override string ToString()
        {
            KeyboardType keyboardType = KeyboardType;
            KeyboardLayout keyboardLayout = KeyboardLayout;
            string hasrgb = HasRgb ? "Has RGB features" : "Has no RGB features";
            string add = $" keyboard type: {keyboardType}; keyboard layout: {keyboardLayout};{hasrgb}";

            return base.ToString() + add;
        }
    }
}
