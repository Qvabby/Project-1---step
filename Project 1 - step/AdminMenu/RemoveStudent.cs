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
    public partial class RemoveStudent : Form
    {
        SqlConnection _con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=StepUniversityDb;Integrated Security=True");
        public RemoveStudent()
        {
            InitializeComponent();
        }

        private void Removeitbtn_Click(object sender, EventArgs e)
        {
            if (RemoveIdNUAD.Value > 0)
            {
                _con.Open();
                SqlCommand cmd = new SqlCommand($"delete from Students_Tb where Id='{RemoveIdNUAD.Value}'", _con);
                cmd.ExecuteNonQuery();
                _con.Close();
            }
        }
    }
}
