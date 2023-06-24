using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_1___step.AdminMenu;

namespace Project_1___step
{
    public partial class AppAdmin : Form
    {
        SqlConnection _con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=StepUniversityDb;Integrated Security=True");
        private int UserId { get; set; }
        public AppAdmin(int userId)
        {
            InitializeComponent();
            UserId = userId;
        }

        private void PanelSwitch(Panel p,Form f)
        {
            if (p.Controls.Count > 0)
                p.Controls.RemoveAt(0);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            p.Controls.Add(f);
            f.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PanelSwitch(MenuPanel, new AddStudent());
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            PanelSwitch(MenuPanel, new RemoveStudent());

        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            PanelSwitch(MenuPanel, new UpdateStudent());
        }

        private void ShowStudentsBtn_Click(object sender, EventArgs e)
        {
            _con.Open();
            SqlCommand cmd = new SqlCommand("select * from Students_Tb", _con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            _con.Close();
            adapter.Fill(dt);
            StudentsDGV.DataSource = dt;
        }

        private void SignOutBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        

        

        private void IdLabel_Click(object sender, EventArgs e)
        {

        }

        private void RemoveIdNUAD_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
