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
using System.Diagnostics;

namespace Accounting_of_component
{
    public partial class MainForm : Form
    {
        SqlConnection sqlConnection = null;
        SqlDataAdapter dataAdapter = null;
        string deleteCommand=string.Empty;
        DataSet dataSet = null;
        string curentTableName= string.Empty;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cBoxTables.DropDownStyle = ComboBoxStyle.DropDownList;
            prihodDate.Select(0, 0);
            string connectionString = ConfigurationManager.ConnectionStrings["CompComponents"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            dataSet = new DataSet();
            dataAdapter = new SqlDataAdapter();
            GetData();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FillDGV2();
            FillDGV3();
            cBoxTables.SelectedIndex = 0;
            сBoxProductType.SelectedIndex = 0;



        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }

        private void FillDGV2()
        {
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.DataSource = dataSet.Tables["Приход"];

        }

        private void FillDGV3()
        {
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.DataSource = dataSet.Tables["Расход"];

        }

        private void RefreshDGV2()
        {

            dataSet.Tables["Приход"].Clear();
            SqlCommand command = new SqlCommand("SELECT * FROM Приход", sqlConnection);
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "Приход");
            dataGridView2.DataSource = dataSet.Tables["Приход"];

        }


        private void GetData()
        {
            
            SqlCommand command = new SqlCommand("SELECT * FROM Номенкулатура", sqlConnection);
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet,"Номенкулатура");
            List<string> list = new List<string>() { "Видеокарты", "Процессоры", "[Материнские платы]", "[Оперативная память]", "Приход", "Расход" };
            foreach (var item in list)
            {
                command.CommandText = $"SELECT * FROM {item}";
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataSet,item);
            }

        }
       

        private void cBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cBoxTables.Text)
            {
                case "Номенкулатура":
                    {
                        curentTableName = "Номенкулатура";
                        btnDltRow.Enabled = false;
                        btnAddLine.Enabled = false;
                        btnUpdate.Enabled= false;
                        dataGridView1.DataSource = dataSet.Tables["Номенкулатура"];
                        dataGridView1.Refresh();
                    }
                    break;
                case "Видеокарты":
                    {

                        btnDltRow.Enabled = true;
                        btnAddLine.Enabled = true;
                        btnUpdate.Enabled= true;    
                        curentTableName = "Видеокарты";
                        deleteCommand = "select * from Видеокарты";
                        dataGridView1.DataSource = dataSet.Tables["Видеокарты"];
                        dataGridView1.Refresh();
                    }
                    break;
                case "Процессоры":
                    {
                        btnDltRow.Enabled = true;
                        btnAddLine.Enabled = true;
                        btnUpdate.Enabled = true;
                        curentTableName = "Процессоры";
                        deleteCommand = "select * from Процессоры";
                        dataGridView1.DataSource = dataSet.Tables["Процессоры"];
                        dataGridView1.Refresh();
                    }
                    break;
                case "Материнские платы":
                    {
                        btnDltRow.Enabled = true;
                        btnAddLine.Enabled = true;
                        btnUpdate.Enabled = true;
                        curentTableName = "[Материнские платы]";
                        deleteCommand = "select * from [Материнские платы]";
                        dataGridView1.DataSource = dataSet.Tables["[Материнские платы]"];
                        dataGridView1.Refresh();
                    }
                    break;
                case "Оперативная память":
                    {
                        btnDltRow.Enabled = true;
                        btnAddLine.Enabled = true;
                        btnUpdate.Enabled = true;
                        curentTableName = "[Оперативная память]";
                        deleteCommand = "select * from [Оперативная память]";
                        dataGridView1.DataSource = dataSet.Tables["[Оперативная память]"];
                        dataGridView1.Refresh();
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {

            var table = dataSet.Tables[curentTableName];
            var row = dataSet.Tables[curentTableName].NewRow();
            var form = new InputForm();
            form.Text = "Добавить";
            form.Build(row);
            try
            {

                if (form.ShowDialog() == DialogResult.OK)
                {
                    table.Rows.Add(row); //добавляем в таблицу
                }  
                using (var adp = new SqlDataAdapter(deleteCommand, sqlConnection))
                using (var cmb = new SqlCommandBuilder(adp))
                {
                    var deleted = adp.Update(dataSet.Tables[curentTableName]);
                    dataSet.Tables.Clear();
                    GetData();
                    dataGridView1.DataSource = dataSet.Tables[curentTableName];
                    //MessageBox.Show("Запись успешно добавлена!");
                }
            }

            catch (ArgumentException)
            {
                MessageBox.Show("Неверный формат данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (idNomen.Text != "" && prihodCount.Text != "" && prihodPrice.Text != "" && prihodDate.Text != "")
                {
                    string productType = сBoxProductType.Text;
                    int idTovara = int.Parse(idNomen.Text);
                    int count1 = int.Parse(prihodCount.Text);
                    int price = int.Parse(prihodPrice.Text);
                    DateTime date = DateTime.Parse(prihodDate.Text);

                    SqlParameter param = new SqlParameter("date2", date);
                    param.DbType = DbType.Date;

                    SqlCommand sqlCommand = new SqlCommand($"INSERT INTO Приход([id товара],Количество,[Дата прихода],[Цена(руб)]) VALUES({idTovara},{count1},@date2,{price})", sqlConnection);
                    sqlCommand.Parameters.Add(param);
                    sqlCommand.ExecuteNonQuery();

                    SqlParameter param2 = new SqlParameter("type", productType);
                    param2.DbType = DbType.String;

                    SqlCommand command = new SqlCommand($"INSERT INTO Номенкулатура([id товара],[Тип товара],Остаток,[Цена(руб)]) VALUES({idTovara},@type,{count1},{price})", sqlConnection);
                    command.Parameters.Add(param2);
                    command.ExecuteNonQuery();

                    dataSet.Tables.Clear();
                    GetData();
                    dataGridView1.DataSource = dataSet.Tables["Номенкулатура"];
                    
                    RefreshDGV2();
                    MessageBox.Show("Запись успешно добавлена!");
                    idNomen.Text=String.Empty;
                    prihodCount.Text=String.Empty;
                    prihodPrice.Text=String.Empty;
                    prihodDate.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnDltRow_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выделенная строка будет удалена,хотите продолжить?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (dataGridView1.SelectedRows.Count==0)
                    return;
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
                try
                {
                    using (var adp = new SqlDataAdapter(deleteCommand, sqlConnection))
                    using (var cmb = new SqlCommandBuilder(adp))
                    {
                        var deleted = adp.Update(dataSet.Tables[curentTableName]);
                        MessageBox.Show("Строка успешно удалена!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else
            {
                return;
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                //получаем объект данных 
                var row = (dataGridView1.CurrentRow.DataBoundItem as DataRowView).Row;
                //создаем форму редактирования
                var form = new InputForm();
                form.Text = "Изменить";
                //строим форму для объекта данных
                form.Build(row);
                //показываем пользователю
                form.ShowDialog();
            }
        }

        private void tBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dataSet.Tables[curentTableName].DefaultView;
            dv.RowFilter = String.Format("[Тип товара] like '%{0}%'", tBoxSearch.Text);
            dataGridView1.DataSource = dv.ToTable();
        }
    }
    
}
