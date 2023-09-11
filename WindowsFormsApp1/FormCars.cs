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
    public partial class FormCars : Form
    {
        public FormCars()
        {
            InitializeComponent();
        }
        SqlCommand cmd = new SqlCommand();


        private void FormCars_Load(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=LD;Initial Catalog=MyDatabase;Integrated Security=True");


        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("insert into TCars (marque, plaque, color)values('" + txtMarque.Text + "', '" + txtPlaque.Text + "', '" + txtColor.Text + "')", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Records inserted");
            conn.Close();
            txtPlaque.Clear();
            txtMarque.Clear();
            txtColor.Clear();
        }
    }
}
