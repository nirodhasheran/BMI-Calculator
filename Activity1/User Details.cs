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
    public partial class User_Details : Form
    {
        string name;
        string gender;
        //static double ibm;
        public User_Details(string name,string gender)
        {
            
            InitializeComponent();
            this.name = name;
            this.gender = gender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight = Double.Parse(tb_weight.Text);
            double height= Double.Parse(tb_height.Text);
            double ibm = weight / (height * height);
           // Math.Round(ibm, 2);

            if (tb_weight.Text == "" || tb_height.Text == "")
            {
                MessageBox.Show("Please enter all the details");

            }
            else
            {
                string weightp = tb_weight.Text;
                string heightp = tb_height.Text;
                string bmi = ibm.ToString();
                
                this.Hide();
                new Calculate_BMI(name,gender,weightp,heightp,bmi).ShowDialog();
                this.Close();

            }

        }

        private void weight_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_Details_Load(object sender, EventArgs e)
        {

        }

        private void height_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
