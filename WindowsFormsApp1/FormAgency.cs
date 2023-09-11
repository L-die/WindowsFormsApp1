using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAgency : Form
    {
        SqlCommand cmd = new SqlCommand();
        public FormAgency()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LD;Initial Catalog=MyDatabase;Integrated Security=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {

            conn.Open();
            cmd = new SqlCommand("insert into TAgence (designation, localisation, statut)values('" + txtDesignAgency.Text + "', '" + txtLocalisation.Text + "', '" + cboStatut.Text + "')", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Records inserted");
            conn.Close();

        }

        private void FormAgency_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("select statut from TStatut", conn);
            cmd.ExecuteReader();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cboStatut.Items.Add(reader.GetString(0));
            }
            conn.Close();
        }
    }
}
