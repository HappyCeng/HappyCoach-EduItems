using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int gecis = 0;

        private void btnFirstButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bana tıkladın, artık evlenmek zorundasın.");
        }

        private void btnFirstButton_FontChanged(object sender, EventArgs e)
        {

        }

        private void btnFirstButton_MouseLeave(object sender, EventArgs e)
        {
            if (gecis % 5 == 1)
            {
                MessageBox.Show("Bana Tıklaaaaa");
            }
            gecis++;
        }
    }
}
