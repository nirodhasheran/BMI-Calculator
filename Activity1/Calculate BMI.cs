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
    public partial class Calculate_BMI : Form
    {
        string name;
        string gender;
        string weight;
        string height;
        string bmi;
        string category;

        //static double bmi;
        
        public Calculate_BMI()
        {
            InitializeComponent();                        //static double result;

        }
        public Calculate_BMI(string name,string gender,string weight,string height,string bmi)
        {
            InitializeComponent();            
            td_result.Text = bmi.ToString();
            this.name = name;
            this.gender = gender;
            this.weight = weight;
            this.height = height;
            this.bmi = bmi;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           /* double result = Double.Parse(td_result.Text);
          

            
            if (result < 18.5)
            {
                td_result.Text = "You are Under weight";

            }
            else if (result >= 18.5 && result <= 24.9)
            {
                td_result.Text = "You are normal weight";

            }
            else if (result >= 25 && result <= 29.9)
            {
                td_result.Text = "You are over weight";

            }
            else if (result > 30.0)
            {
                td_result.Text = "You are obese weight";
            }
            else {
                td_result.Text = "ssssss";

            }*/
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            double result = Double.Parse(td_result.Text);


            String finalAns = "";

            
            if (result < 18.5)
            {
                finalAns = "You are Under weight";

            }
            else if (result >= 18.5 && result <= 24.9)
            {
                finalAns = "You are normal weight";

            }
            else if (result >= 25 && result <= 29.9)
            {
                finalAns = "You are over weight";

            }
            else
            {
                finalAns = "You are obese weight";
            }
               
           
                
        
           
            this.Hide();

            new RangeView(this.name,this.gender,this.weight,this.height,this.bmi,finalAns).ShowDialog();

            this.Close();
          


          
                       

             

               
        }
            
    
            

        

        private void Calculate_BMI_Load(object sender, EventArgs e)
        {

        }
    }
}
