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
    public partial class UpdateStudent : Form
    {
        SqlConnection _con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=StepUniversityDb;Integrated Security=True");
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void UpdateItbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(UpdateNameTb.Text) && !string.IsNullOrWhiteSpace(UpdateLastNameTb.Text) && UpdateGroupIdNUAD.Value != 0 && UpdateIdNUAD.Value != 0)
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand($"Update Students_Tb Set Name = '{UpdateNameTb.Text}',LastName = '{UpdateLastNameTb.Text}',GroupId = '{UpdateGroupIdNUAD.Value}' where Id = '{UpdateIdNUAD.Value}'", _con);
                cmd.ExecuteNonQuery();
                _con.Close();
            }
        }
    }
}
