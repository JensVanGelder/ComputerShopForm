using System;
using System.Windows.Forms;

namespace ComputerShopForm
{
    internal class ProductInfoHandler
    {
        private FormProductInfo _form;

        public ProductInfoHandler(FormProductInfo form)
        {
            _form = form;
        }

        public IProduct CreateLaptop()
        {
            return new Laptop(
                _form.TextId,
                _form.TextName,
                _form.TextPrice,
                "https://bucketcomputershopform.s3.eu-central-1.amazonaws.com/HP+Envy+15+edit.png",
                _form.TextSummary,
                _form.TextStock,
                _form.TextRam,
                _form.TextMoBo,
                _form.TextHdd,
                _form.TextCpu,
                _form.TextPsu,
                Convert.ToInt32(_form.TextScreenSize),
                _form.TextScreenType,
                Convert.ToDouble(_form.TextWeight)
                );
        }

        public IProduct CreateWorkstation()
        {
            return new Workstation(
                _form.TextId,
                _form.TextName,
                _form.TextPrice,
                "https://bucketcomputershopform.s3.eu-central-1.amazonaws.com/HP+Envy+15+edit.png",
                _form.TextSummary,
                _form.TextStock,
                _form.TextRam,
                _form.TextMoBo,
                _form.TextHdd,
                _form.TextCpu,
                _form.TextPsu,
                _form.TextRaid
                );
        }

        public IProduct CreateGamingPc()
        {
            return new GamingPc(
                _form.TextId,
                _form.TextName,
                _form.TextPrice,
                "https://bucketcomputershopform.s3.eu-central-1.amazonaws.com/HP+Envy+15+edit.png",
                _form.TextSummary,
                _form.TextStock,
                _form.TextRam,
                _form.TextMoBo,
                _form.TextHdd,
                _form.TextCpu,
                _form.TextPsu,
                _form.TextGpu,
                _form.TextRgb,
                true
                );
        }

        public void CheckInput(KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("error");
            }
        }

        public bool CheckIfEmpty()
        {
            bool check = false;
            foreach (Control text in _form.Controls)
            {
                if (text is TextBox)
                {
                    if (string.IsNullOrEmpty(text.Text))
                    {
                        check = true;
                        break;
                    }
                }
            }
            return check;
        }

        public void SetAllTextboxesToWrite()
        {
            foreach (Control ctrl in _form.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = ctrl as TextBox;
                    if (tb.ReadOnly)
                    {
                        tb.ReadOnly = false;
                    }
                }
            }
        }
    }
}