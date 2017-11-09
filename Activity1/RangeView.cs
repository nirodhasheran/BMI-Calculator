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
    public partial class RangeView : Form
    {
        string name;
        string gender;
        string weight;
        string height;
        string bmi;
        string category;

        public RangeView()
        {
            InitializeComponent();
        }

        public RangeView(string name, string gender, string weight, string height, string bmi,string category)
        {

            InitializeComponent();
            td_range.Text = category.ToString();
            try
            {
                String text1 = td_range.Text;
                //String text2 = comboBox1.Text;

                SqlConnection con = new DBConnector().getConnection();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO [BMIcalculation] VALUES('"+name+"','"+gender+"','"+weight+"','"+height+"','"+bmi+"','"+category+"')";
                cmd.ExecuteNonQuery();
                // MessageBox.Show(" Successfully Login", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                //MessageBox.Show("Already calculated ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // con.Close();
            }

        }

        private void RangeView_Load(object sender, EventArgs e)
        {

        }

        private void td_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
           
                
        }

      
    }
}
