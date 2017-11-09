using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity1
{
    class DBConnector
    {
        SqlConnection con = null;
         
        public SqlConnection getConnection()
        {
            try
            {

               // con = new SqlConnection(ConfigurationManager.ConnectionStrings["NIC.Properties.Settings.nicConnectionString"].ConnectionString);
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["BMIcalculationConnectionString"].ConnectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error: DBConnector", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }
    }
}
