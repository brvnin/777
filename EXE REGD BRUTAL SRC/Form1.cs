using KeyAuth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EXE_REGD_BRUTAL_SRC
{
    public partial class Form1 : Form
    {
        public static api KeyAuthApp = new api(
    name: "aimkillmax",
    ownerid: "oG9H2gswHi",
    version: "1.0"
//path: @"Your_Path_Here"
);

        public Form1()
        {
            InitializeComponent();
            LoadInformation();
            KeyAuthApp.init();
        }



        private void SaveUserAndPass()
        {
            EXE_REGD_BRUTAL_SRC.Properties.Settings.Default.User = User.Text;
            EXE_REGD_BRUTAL_SRC.Properties.Settings.Default.Pass = Pass.Text;
            EXE_REGD_BRUTAL_SRC.Properties.Settings.Default.Save();
        }


        private void LoadInformation()
        {
            User.Text = EXE_REGD_BRUTAL_SRC.Properties.Settings.Default.User;
            Pass.Text = EXE_REGD_BRUTAL_SRC.Properties.Settings.Default.Pass;
        }




        private void guna2Button1_Click(object sender, EventArgs e)
        {
            KeyAuthApp.login(User.Text, Pass.Text);
            SaveUserAndPass();
            if (KeyAuthApp.response.success)
            {

                Form2 main = new Form2();
                main.Show();
                this.Hide();


            }
            else
            {
                lable.Text = KeyAuthApp.response.message;
                Console.Beep(400, 300);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
