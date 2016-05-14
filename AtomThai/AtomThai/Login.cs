using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtomThai
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text.ToLower() == TestUser.UserName.ToLower() && txtPW.Text == TestUser.Password)
            {
                MessageBox.Show("ID is correct", "Caption");
            }
            else
            {
                MessageBox.Show("ID is incorrect", "Caption");
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            StuffRegister fmStuffRegister = new StuffRegister();
            fmStuffRegister.Show();
        }
    }


    static public class TestUser
    {
        public static string UserName = "test";
        public static string Password = "1234";
    }

}
