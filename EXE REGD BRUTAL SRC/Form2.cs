using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXE_REGD_BRUTAL_SRC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // Form load hote hi panels ko sahi jagah fix karne ke liye
            SetupPanels();

            // Sabse pehle Aimbot dikhao
            ShowTab(panel2);
        }

        private void SetupPanels()
        {
            // Sabhi panels ko ek hi jagah par set karne ke liye (x: 12, y: 80 - adjust as per your UI)
            // Point ka matlab hai ki wo button ke neeche kahan se shuru honge
            Point panelLocation = new Point(12, 75);
            Size panelSize = new Size(740, 380); // Aapke menu ka size

            Panel[] allPanels = { panel2, panel11, panel20, panel29 };

            foreach (Panel p in allPanels)
            {
                p.Location = panelLocation;
                p.Size = panelSize;
                p.Visible = false; // Pehle sab hide
            }
        }

        private void ShowTab(Panel activePanel)
        {
            // Saare panels hide karo
            panel2.Visible = false;
            panel11.Visible = false;
            panel20.Visible = false;
            panel29.Visible = false;

            // Sirf select kiya hua panel dikhao
            activePanel.Visible = true;
            activePanel.BringToFront();
        }

        // Button Clicks
        private void guna2GradientButton1_Click(object sender, EventArgs e) => ShowTab(panel2);
        private void guna2GradientButton2_Click(object sender, EventArgs e) => ShowTab(panel11);
        private void guna2GradientButton3_Click(object sender, EventArgs e) => ShowTab(panel20);
        private void guna2GradientButton4_Click(object sender, EventArgs e) => ShowTab(panel29);
    }
}