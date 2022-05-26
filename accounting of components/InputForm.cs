using ExmapleNS.Controls;
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
    public partial class InputForm : Form
    {
        //данные
        public DataRow Row { get; private set; }

        public InputForm()
        {
            InitializeComponent();
        }

        public void Build(DataRow row)
        {
            var con = this.Controls;
            Row = row;
            //Row.Table.Columns.RemoveAt(0);
            //создаем FieldPanel для каждого поля, отображаем в pnMain
            foreach (DataColumn col in row.Table.Columns)
            {
                if (col.ColumnName == "Id" || col.ColumnName=="id")
                    continue;
                var pn = new FieldPanel() { Parent = pnMain, Name = col.ColumnName };
                pn.lbName.Text = col.ColumnName;
                pn.tbField.Text = row[col.ColumnName].ToString();
            }
        }

        //парсинг и проверка на правильность
        private void UpdateValue()
        {
            //перебираем FieldPanel, заносим значения в DataRow
            foreach (DataColumn col in Row.Table.Columns)
            {
                if (col.ColumnName == "Id" || col.ColumnName == "id")
                    continue;
                var pn = (FieldPanel)pnMain.Controls[col.ColumnName];
                Row[col.ColumnName] = pn.tbField.Text;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateValue();//парсинг и проверка на правильность
                DialogResult = DialogResult.OK;//выход из формы, если все введено правильно
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;//выход из формы
        }
    }
}
