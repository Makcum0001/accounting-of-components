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
using System.Configuration;

namespace accounting_of_components
{
    public partial class MainForm : Form
    {
        SqlConnection sqlConnection = null;
        public MainForm()
        {
            InitializeComponent();
            
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CompComponents"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();    



        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection!=null && sqlConnection.State!=ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }
    }
}
