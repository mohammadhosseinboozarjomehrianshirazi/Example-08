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
    public partial class add_phone : Form
    {
        public add_phone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            string model = textBox1.Text;
            string color = textBox2.Text;
            string price = textBox3.Text;
                string cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\USER\\Documents\\Visual Studio 2015\\Projects\\database\\WindowsFormsApplication13\\Database1.mdf\";Integrated Security=True";
            SqlConnection sc = new SqlConnection(cs);
                sc.Open();
            string cmd = "insert into [table] (model,color,price) values" +
                "('" + model + "','" + color + "','" + price + "')";
            SqlCommand command = new SqlCommand(cmd, sc);
                if(command.ExecuteNonQuery()==1)
              MessageBox.Show ("باموفقیت اضافه شد");
                else
                    MessageBox.Show("باموفقیت اضافه نشد");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
