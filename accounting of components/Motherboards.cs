using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_of_component
{
    public partial class Motherboards : Form
    {
        public Motherboards()
        {
            InitializeComponent();
        }

        private void Motherboards_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Добавить";
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                
                
            }
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
