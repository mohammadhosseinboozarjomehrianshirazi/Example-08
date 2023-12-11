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

namespace WindowsFormsApplication13
{
    public partial class phones : Form
    {
        public phones()
        {
            InitializeComponent();
        }

        private void phones_Load(object sender, EventArgs e)
        {
            try { 
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\Visual Studio 2015\Projects\database\WindowsFormsApplication13\Database1.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();

                string cmd = "select * from [table]";
                SqlCommand command = new SqlCommand(cmd, connection);
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    listBox1.Items.Add(sdr["customer name"]);
                }

              }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
