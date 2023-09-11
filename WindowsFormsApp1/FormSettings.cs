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

namespace WindowsFormsApp1
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=LD;Initial Catalog=MyDatabase;Integrated Security=True");


        private void btnAddAgency_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("insert into TStatut (statut)values('" + txtAddStatut.Text + "')",conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Records inserted");
            conn.Close();
            txtAddStatut.Clear();
        }
    }
}
