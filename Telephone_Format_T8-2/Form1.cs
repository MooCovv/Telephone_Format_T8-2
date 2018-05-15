using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Format_T8_2
{
    public partial class v : Form
    {
        public v()
        {
            InitializeComponent();
        }

        private bool IsValidNumber(string i)
        {
            const int VALID_LENGTH = 10;
            bool valid = true;

            if(i.Length == VALID_LENGTH)
            {
                foreach (char ch in i)
                {
                    if (!char.IsDigit(ch))
                    {
                        valid = false;
                    }
                }
            }
            else
            {
                valid = false;
            }
            return valid;
        }

        private void 
        private void formatButton_Click(object sender, EventArgs e)
        {

        }
    }
}
