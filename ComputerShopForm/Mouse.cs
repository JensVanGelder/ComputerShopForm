using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ComputerShopForm.Peripheral;

namespace ComputerShopForm
{
    class Mouse : Peripherals
    {
        public bool HasChargeStation { get; set; }

        public int SideButtons { get; set; }

        public int Dpi { get; set; }

        public Mouse(int id, string name, double price, string imagepath, string summary, int stock, WiredOrWireless wiredOrWireless, UsbConnection usbConnection, bool haschargestation, int sidebuttons, int dpi)
            : base(id, name, price, imagepath, summary, stock, wiredOrWireless, usbConnection)
        {
            HasChargeStation = haschargestation;
            SideButtons = sidebuttons;
            Dpi = dpi;
        }

        public override string ToString()
        {
            string haschargestation = HasChargeStation ? "Has Chargestation" : "Has no chargestation";
            string add = $" {haschargestation}; has {SideButtons} sidebuttons and {Dpi} DPI";

            return base.ToString() + add;
        }

    }
}
