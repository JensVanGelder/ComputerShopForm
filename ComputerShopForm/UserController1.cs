using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShopForm
{
    public partial class UserController1 : UserControl
    {
        public UserController1()
        {
            InitializeComponent();
        }

        public string Name
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        private void UserController1_Load(object sender, EventArgs e)
        {
        }
    }
}