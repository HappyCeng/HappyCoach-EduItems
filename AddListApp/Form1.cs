using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddListApp
{
    public partial class SoundList : Form
    {
        public SoundList()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if ((txtSarkiGirdi.Text == "Lütfen Şarkı Adı Giriniz" || txtSarkiGirdi.Text == "") && (txtSanatciAdi.Text == "Lütfen Sanatçı Adını Giriniz"  || txtSanatciAdi.Text == ""))//&& ve durumu 2 durumunda denk gelmesi gerekirse olmaz.
            {
                MessageBox.Show("Lütfen Şarkı Adı Giriniz..."); 
            }
            else 
            {
                lstBoxSarkiListesi.Items.Add(txtSanatciAdi.Text.ToUpper() + " - " + txtSarkiGirdi.Text.ToUpper());
                Items ıtems = new Items();
                ıtems.TextClear(txtSarkiGirdi,"");
                ıtems.TextClear(txtSanatciAdi,"");
            }
            
        }

    }
}
