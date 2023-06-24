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

namespace Project_1___step.AdminMenu
{
    public partial class AddStudent : Form
    {
        SqlConnection _con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=StepUniversityDb;Integrated Security=True");
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AdditBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameTb.Text) && !string.IsNullOrWhiteSpace(LastNameTb.Text) && GroupIDNUAD.Value != 0)
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand($"insert into Students_Tb(Name, LastName, GroupId) values('{NameTb.Text}','{LastNameTb.Text}','{GroupIDNUAD.Value}')", _con);
                cmd.ExecuteNonQuery();
                _con.Close();
            }
            else
            {
                MessageBox.Show("Error with inputs", "Error");
            }
        }
    }
}
