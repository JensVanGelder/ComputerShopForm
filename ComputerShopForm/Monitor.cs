using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ComputerShopForm.Peripheral;

namespace ComputerShopForm
{
    class Monitor : Product
    {
        public int InchSize { get; set; }

        public ScreenPanel ScreenPanel { get; set; }

        public Monitor (int id, string name, double price, string imagepath, string summary, int stock, int inchsize, ScreenPanel screenPanel )
            : base(id, name, price, imagepath, summary, stock)
        {
            InchSize = inchsize;
            ScreenPanel = screenPanel;
        }

        public override string ToString()
        {
            ScreenPanel screenPanel = ScreenPanel;
            string add = $"Has a {screenPanel} type of screenpanel and an {InchSize} Inch Screensize";
            return base.ToString() + add;
        }
    }
}
