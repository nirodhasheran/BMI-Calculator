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

namespace Activity1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Please enter all the details");

            }
            else
            {
                String text1 = textBox1.Text;
                String text2 = comboBox1.Text;
                try
                {
                    

                    
                    MessageBox.Show(" Successfully Login", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    //MessageBox.Show("Already calculated ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // con.Close();
                }
                //MessageBox.Show("Successfully Login");
                this.Hide();
                new User_Details(text1,text2).ShowDialog();
                this.Close();

            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
