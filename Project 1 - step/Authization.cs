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
    public partial class Authization : Form
    {
        SqlConnection _con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=StepUniversityDb;Integrated Security=True");
        public Authization()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            _con.Open();
            SqlCommand cmd = new SqlCommand($"select * from User_Tb where Username = '{UsernameTb.Text}' and Password = '{PasswordTb.Text}'", _con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            _con.Close();


            if (dt.Rows.Count > 0 && dt.Rows.Count < 2)
            {
                var value = dt.Rows[0][3];
                if (Convert.ToString(value) == "administrator")
                {

                    if (Form1.MP.Controls.Count > 0)
                    {
                        Form1.MP.Controls.RemoveAt(0);
                    }

                    AppAdmin app = new AppAdmin(Convert.ToInt32(dt.Rows[0][0]));
                    app.TopLevel = false;
                    app.Dock = DockStyle.Fill;
                    app.FormBorderStyle = FormBorderStyle.None;
                    Form1.MP.Controls.Add(app);
                    app.Show();
                    Form1.isloggin = true;
                    Form1.loginbtn.Text = "Log Out";
                    Form1.loginbtn.Location = new Point(763, 12);
                    Form1.registerBtn.Visible = false;
                    //763, 12
                }
                else if (Convert.ToString(value) == "teacher")
                {

                    if (Form1.MP.Controls.Count > 0)
                    {
                        Form1.MP.Controls.RemoveAt(0);
                    }

                    AppTeacher app = new AppTeacher(Convert.ToInt32(dt.Rows[0][0]));
                    app.TopLevel = false;
                    app.Dock = DockStyle.Fill;
                    app.FormBorderStyle = FormBorderStyle.None;
                    Form1.MP.Controls.Add(app);
                    app.Show();
                    Form1.isloggin = true;
                    Form1.loginbtn.Text = "Log Out";
                    Form1.loginbtn.Location = new Point(763, 12);
                    Form1.registerBtn.Visible = false;
                }
            }
        }
    }
}
