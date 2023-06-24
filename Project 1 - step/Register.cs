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
    public partial class Register : Form
    {

        SqlConnection _con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=StepUniversityDb;Integrated Security=True");
        public Register()
        {
            InitializeComponent();
        }
        private bool UsernameExists()
        {
            UsernameL.Text = "Username";
            _con.Open();
            SqlCommand cmd = new SqlCommand($"select * from User_Tb where Username = '{UsernameTb.Text}'", _con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            _con.Close();

            if (dt.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }
        private void AddUser(string Username, string Password, string Role)
        {
            _con.Open();
            SqlCommand cmd = new SqlCommand($"insert into User_Tb(Username, Password, UserRole) values ('{Username}', '{Password}', '{Role}')", _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (UsernameExists())
            {
                UsernameL.Text = "Username (That Username Already Exists)";
            }
            else
            {
                string parameter = AdministratorRB.Checked ? "administrator" : "teacher";
                AddUser(UsernameTb.Text, PasswordTb.Text, parameter);
                Close();
            }
        }
    }
}
