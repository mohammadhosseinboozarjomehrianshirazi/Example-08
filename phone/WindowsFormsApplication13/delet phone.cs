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
    public partial class delet_phone : Form
    {
        public delet_phone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id= textBox1.Text;
                string cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\USER\\Documents\\Visual Studio 2015\\Projects\\database\\WindowsFormsApplication13\\Database1.mdf\";Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string strsql = "DELETE FROM [Table] where(id)='" + id+ "'; ";
                SqlCommand command = new SqlCommand(strsql, con);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

