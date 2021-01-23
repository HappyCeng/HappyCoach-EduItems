using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileProcess
{
    public partial class MainPage : Form
    {
        UserInfo userInfo = new UserInfo();
        public MainPage()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!userInfo.getSessionInfo())
            {
                LoginForm loginForm = new LoginForm();
                this.Opacity = 0;
                this.ShowInTaskbar = false;
                loginForm.Show();
            }
        }

        public void getUserInfo(UserInfo Info)
        {
            userInfo = Info;
        }

        private void btnListProduct_Click(object sender, EventArgs e)
        {
            ProductListForm productListForm = new ProductListForm();
            productListForm.Location = new Point(200, 200);
            productListForm.MdiParent = this;
            productListForm.Show();
        }
    }
}
