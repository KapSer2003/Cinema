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

namespace Cinema
{
    public partial class Autorization : Form
    {
       
        public Autorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Data.conString);
            using (SqlCommand com = con.CreateCommand())
            {
                com.CommandText = "AutorizationUser";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@login", textBox1.Text);
                com.Parameters.AddWithValue("@pass", textBox2.Text);
                try
                {
                    con.Open();
                    com.ExecuteNonQuery();
                    Data.autoriz = true;
                    MessageBox.Show("Вы успешно вошли");
                    this.Close();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
