using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace FileProcess
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Lütfen geçerli bir kullanıcı adı veya şifre giriniz.");
            }
            else
            {
                if (File.Exists("E:\\StokApp\\login.txt"))
                {
                    StreamWriter dosyayaz = File.AppendText("E:\\StokApp\\login.txt");
                    dosyayaz.WriteLine(txtUserID.Text + "#" + txtPassword.Text);
                    dosyayaz.Close();
                    this.Dispose();
                }
            }
        }
    }
}
