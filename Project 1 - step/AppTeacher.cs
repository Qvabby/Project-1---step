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

namespace Project_1___step
{
    public partial class AppTeacher : Form
    {
        SqlConnection _con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=StepUniversityDb;Integrated Security=True");
        public int UserId { get; set; }
        public AppTeacher(int userId)
        {
            InitializeComponent();
            UserId = userId;
        }


        private void AddPointBtn_Click(object sender, EventArgs e)
        {
            if (!IdNUAD.Visible)
            {
                IdNUAD.Visible = true;
                PointNUAD.Visible = true;
                StudIdLabel.Visible = true;
                StudPointLabel.Visible = true;
                AddBtn.Visible = true;
            }
            else
            {
                IdNUAD.Visible = false;
                PointNUAD.Visible = false;
                StudIdLabel.Visible = false;
                StudPointLabel.Visible = false;
                AddBtn.Visible = false;
            }
        }

        private void ShowStuds(int groupid)
        {
            _con.Close();
            _con.Open();
            SqlCommand cmd = new SqlCommand($"select * from Students_Tb where GroupId = '{groupid}'", _con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            _con.Close();

            StudentsDGV.DataSource = dt;
        }


        private void AppTeacher_Load(object sender, EventArgs e)
        {
            _con.Open();
            SqlCommand cmd = new SqlCommand("select GroupId from Students_Tb", _con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            _con.Close();
            bool can = true;
            foreach (DataRow item in dt.Rows)
            {
                foreach (var i in GroupsCB.Items)
                {
                    if (i.ToString() == item[0].ToString())
                    {
                        can = false;
                    }
                }
                if (can)
                {
                    GroupsCB.Items.Add(item[0]);
                }
                can = true;
            }
        }

        private void SignOutBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            


            if (IdNUAD.Value > 0)
            {
                bool can = true;
                _con.Open();
                SqlCommand cmd2 = new SqlCommand($"select * from Students_Tb where Id = '{IdNUAD.Value}'", _con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DataRow dr = dt.Rows[0];
                if (!string.IsNullOrWhiteSpace(dr[4].ToString()))
                {
                    can = false;
                }
                if (can)
                {
                    SqlCommand cmd = new SqlCommand($"Update Students_Tb Set Points = '{PointNUAD.Value}' where Id = '{IdNUAD.Value}'", _con);
                    cmd.ExecuteNonQuery();
                    
                    ShowStuds(Convert.ToInt32(GroupsCB.SelectedItem));
                }
                else
                {
                    MessageBox.Show("Already assigned points", "cant change");
                }
                _con.Close();
            }
            else
            {
                MessageBox.Show("Error with Inputs", "Error");
            }
        }

        private void GroupsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowStuds(Convert.ToInt32(GroupsCB.SelectedItem));
        }
    }
}
