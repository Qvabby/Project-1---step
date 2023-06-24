using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_1___step
{
    public partial class Form1 : Form
    {
        public static bool isloggin { get; set; } = false;
        public static Panel MP { get; set; }
        public static Control loginbtn { get; set; }
        public static Control registerBtn { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!isloggin)
            {
                if (MainPanel.Controls.Count > 0)
                {
                    MainPanel.Controls.RemoveAt(0);
                }
                Authization Log = new Authization();
                Log.TopLevel = false;
                Log.Dock = DockStyle.Fill;
                Log.FormBorderStyle = FormBorderStyle.None;
                MainPanel.Controls.Add(Log);
                Log.Show();
            }
            else
            {
                //682, 12
                LoginBtn.Text = "Log In";
                if (MainPanel.Controls.Count > 0)
                {
                    MainPanel.Controls.RemoveAt(0);
                }
                isloggin = false;
                LoginBtn.Location = new Point(682, 12);
                registerBtn.Visible = true; 

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MainPanel.Controls.Count > 0)
            {
                MainPanel.Controls.RemoveAt(0);
            }
            Register Reg = new Register();
            Reg.TopLevel = false;
            Reg.Dock = DockStyle.Fill;
            Reg.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(Reg);
            Reg.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MP = MainPanel;
            loginbtn = LoginBtn;
            registerBtn = RegisterBtn;
        }
    }
}
