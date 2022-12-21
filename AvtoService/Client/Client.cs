using AvtoService.Client;
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

namespace AvtoService
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = true;
            dataGridView1.AllowUserToResizeRows = false;

            
            DataBase dataBase = new DataBase();
            dataBase.openConnection();
            string script1 = "SELECT ФИО FROM Клиент WHERE ПаспортныеДанные=@login";
            SqlCommand sqlCommand = new SqlCommand(script1, dataBase.getConnection());
            sqlCommand.Parameters.Add("@login", SqlDbType.VarChar).Value = DataForUsing.loginUser;
            labelFio.Text = sqlCommand.ExecuteScalar().ToString();
            dataBase.closeConnection();

            textBox1.Visible = false;
            label1.Visible = false;
            this.FormClosing += ClientForm_FormClosing;
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = false;
            }
        }
        
        private void buttonClientPersonalArea_Click(object sender, EventArgs e)
        {
            PersonalArea personal = new PersonalArea();
            personal.ShowDialog();
            textBox1.Visible = false;
            label1.Visible = false;
        }

        private void buttonClientCheckOrder_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label1.Visible = false;

            DataBase dataBase = new DataBase();
            dataBase.openConnection();
            string script1 = "SELECT IdКлиента FROM Клиент WHERE ПаспортныеДанные=@login";
            SqlCommand sqlCommand = new SqlCommand(script1, dataBase.getConnection());
            sqlCommand.Parameters.Add("@login", SqlDbType.VarChar).Value = DataForUsing.loginUser;
            string script = "SELECT (SELECT ВидРабот FROM СотрудникНарядЗаказ WHERE (НарядЗаказ.НомерНарядЗаказа = СотрудникНарядЗаказ.НомерНарядЗаказа)) AS [Вид работ], IdКлиента, ДатаОформления AS [Дата оформления], ДатаИсполнения AS [Дата исполнения], Гарантия, СтатусОплаты AS [Статус оплаты], ГосНомер AS [Гос. номер], VINКод, Цвет, МаркаМашины AS [Марка машины] FROM НарядЗаказ WHERE IdКлиента = @IdКлиента";
            SqlCommand sqlCommand1 = new SqlCommand(script, dataBase.getConnection());
            sqlCommand1.Parameters.Add("@IdКлиента", SqlDbType.VarChar).Value = sqlCommand.ExecuteScalar().ToString();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand1);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.ReadOnly = true;
            this.dataGridView1.Columns["IdКлиента"].Visible = false;
            dataBase.closeConnection();
        }

        private void buttonClientCheckZapchasti_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = true;

            DataBase dataBase = new DataBase();
            string script = "SELECT НомерЗапчасти, Название AS [Название запчасти], Цена, НаличиеНаСкладе AS [Наличие на складе], ЕдИзмерения AS [ШТ/Л] FROM Запчасть";
            SqlCommand sqlCommand = new SqlCommand(script, dataBase.getConnection());
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.ReadOnly = true;
            this.dataGridView1.Columns["НомерЗапчасти"].Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"[Название запчасти] LIKE '%{textBox1.Text}%'";
            if (textBox1.Text == "")
            {
                DataBase dataBase = new DataBase();
                string script = "SELECT НомерЗапчасти, Название AS [Название запчасти], Цена, НаличиеНаСкладе AS [Наличие на складе], ЕдИзмерения AS [ШТ/Л] FROM Запчасть";
                SqlDataAdapter adapter = new SqlDataAdapter(script, dataBase.getConnection());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                this.dataGridView1.Columns["НомерЗапчасти"].Visible = false;
            }
        }
    }
}
