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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string newLine = string.Empty, UserName = string.Empty, UserPass = string.Empty;
            string[] tmpArr = new string[2];

            if (txtUserName.Text == "" || txtUserPass.Text == "") 
            {
                MessageBox.Show("Lütfen geçerli bir kullanıcı adı giriniz.");
            }
            else 
            {
                if (File.Exists("E:\\StokApp\\login.txt"))
                {
                    try { 
                        StreamReader LoginFile = File.OpenText("E:\\StokApp\\login.txt");
                        newLine = LoginFile.ReadLine();
                        tmpArr = newLine.Split('#');
                        UserName = tmpArr[0];
                        UserPass = tmpArr[1];

                        if (txtUserName.Text == UserName && txtUserPass.Text == UserPass)
                        {
                            UserInfo userInfo = new UserInfo();
                            userInfo.UserName = UserName;
                            userInfo.UserPassword = UserPass;
                            userInfo.SessionControl(userInfo);
                            if (userInfo.getSessionInfo())
                            {
                                MainPage mainPage = new MainPage();
                                mainPage.getUserInfo(userInfo);
                                mainPage.Opacity = 1;
                                mainPage.ShowInTaskbar = true;
                                mainPage.Show();
                                this.Dispose();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı bilgilerini kontrol ediniz.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERR-0001 : Beklenmeyen bir hata oluştu.");
                    }
                }
                else 
                {
                    MessageBox.Show("Lütfen geçerli bir kullanıcı adı giriniz.");
                }
            }
        }
    }
}
