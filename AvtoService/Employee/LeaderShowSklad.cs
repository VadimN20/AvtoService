using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AvtoService.Employee
{
    public partial class LeaderShowSklad : Form
    {
        public LeaderShowSklad()
        {
            InitializeComponent();

            dgvSkladTable.RowHeadersVisible = false;
            dgvSkladTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSkladTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSkladTable.AllowUserToAddRows = false;
            dgvSkladTable.AllowUserToResizeColumns = false;
            dgvSkladTable.AllowUserToResizeRows = false;

            DataBase dataBase = new DataBase();
            string script = "SELECT НомерЗапчасти, Название AS [Название запчасти], Цена, НаличиеНаСкладе AS [Наличие на складе], ЕдИзмерения AS [ШТ/Л] FROM Запчасть";
            SqlDataAdapter adapter = new SqlDataAdapter(script, dataBase.getConnection());
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvSkladTable.DataSource = dataTable;
            this.dgvSkladTable.Columns["НомерЗапчасти"].Visible = false;
            label5.Visible = false;

        }

        private void searchText1_TextChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
            (dgvSkladTable.DataSource as DataTable).DefaultView.RowFilter = $"[Название запчасти] LIKE '%{searchText1.Text}%'";
            if (searchText1.Text == "")
            {
                DataBase dataBase = new DataBase();
                string script = "SELECT НомерЗапчасти, Название AS [Название запчасти], Цена, НаличиеНаСкладе AS [Наличие на складе], ЕдИзмерения AS [ШТ/Л] FROM Запчасть";
                SqlDataAdapter adapter = new SqlDataAdapter(script, dataBase.getConnection());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvSkladTable.DataSource = dataTable;
                this.dgvSkladTable.Columns["НомерЗапчасти"].Visible = false;
            }
        }

        private void searchNum1_ValueChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
            (dgvSkladTable.DataSource as DataTable).DefaultView.RowFilter = $"[Цена] = " + searchNum1.Value.ToString();
            if (searchNum1.Value == 0)
            {
                DataBase dataBase = new DataBase();
                string script = "SELECT НомерЗапчасти, Название AS [Название запчасти], Цена, НаличиеНаСкладе AS [Наличие на складе], ЕдИзмерения AS [ШТ/Л] FROM Запчасть";
                SqlDataAdapter adapter = new SqlDataAdapter(script, dataBase.getConnection());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvSkladTable.DataSource = dataTable;
                this.dgvSkladTable.Columns["НомерЗапчасти"].Visible = false;
            }
        }

        private void searchNum2_ValueChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
            (dgvSkladTable.DataSource as DataTable).DefaultView.RowFilter = $"[Наличие на складе] = " + searchNum2.Value.ToString();
            if (searchNum2.Value == 0)
            {
                DataBase dataBase = new DataBase();
                string script = "SELECT НомерЗапчасти, Название AS [Название запчасти], Цена, НаличиеНаСкладе AS [Наличие на складе], ЕдИзмерения AS [ШТ/Л] FROM Запчасть";
                SqlDataAdapter adapter = new SqlDataAdapter(script, dataBase.getConnection());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvSkladTable.DataSource = dataTable;
                this.dgvSkladTable.Columns["НомерЗапчасти"].Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
            (dgvSkladTable.DataSource as DataTable).DefaultView.RowFilter = $"[ШТ/Л] LIKE '%{comboBox1.Text}%'";
            if (comboBox1.Text == "")
            {
                DataBase dataBase = new DataBase();
                string script = "SELECT НомерЗапчасти, Название AS [Название запчасти], Цена, НаличиеНаСкладе AS [Наличие на складе], ЕдИзмерения AS [ШТ/Л] FROM Запчасть";
                SqlDataAdapter adapter = new SqlDataAdapter(script, dataBase.getConnection());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvSkladTable.DataSource = dataTable;
                this.dgvSkladTable.Columns["НомерЗапчасти"].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            AddZapchast addZapchast = new AddZapchast();
            addZapchast.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            try
            {
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запчасть из списка?", "Подтверждение на удаление запчасти", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    DataBase dataBase = new DataBase();
                    SqlCommand command = new SqlCommand("DELETE FROM Запчасть WHERE НомерЗапчасти=@nomer", dataBase.getConnection());
                    command.Parameters.Add("@nomer", SqlDbType.Int).Value = dgvSkladTable.SelectedRows[0].Cells["НомерЗапчасти"].Value.ToString();
                    dataBase.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        dgvSkladTable.DataSource = null;
                        MessageBox.Show("Запчасть удалена");
                        string script = "SELECT НомерЗапчасти, Название AS [Название запчасти], Цена, НаличиеНаСкладе AS [Наличие на складе], ЕдИзмерения AS [ШТ/Л] FROM Запчасть";
                        SqlDataAdapter adapter = new SqlDataAdapter(script, dataBase.getConnection());
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvSkladTable.DataSource = dataTable;
                        this.dgvSkladTable.Columns["НомерЗапчасти"].Visible = false;
                    }
                    else
                        MessageBox.Show("Запчасть не найдена");

                    dataBase.closeConnection();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Такой запчасти не существует");
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            for (int i = 0; i < dgvSkladTable.Rows.Count; i++)
            {
                for (int j = 0; j < dgvSkladTable.Columns.Count; j++)
                {
                    DataBase dataBase = new DataBase();
                    dataBase.openConnection();
                    string script = "UPDATE Запчасть SET Название = @naz, Цена = @price, НаличиеНаСкладе = @nalichie, ЕдИзмерения = @EdIzm WHERE НомерЗапчасти = @nomer";
                    SqlCommand sqlCommand = new SqlCommand(script, dataBase.getConnection());
                    sqlCommand.Parameters.Add("@nomer", SqlDbType.Int).Value = dgvSkladTable.Rows[i].Cells[0].Value;
                    sqlCommand.Parameters.Add("@naz", SqlDbType.VarChar).Value = dgvSkladTable.Rows[i].Cells[1].Value;
                    sqlCommand.Parameters.Add("@price", SqlDbType.Int).Value = dgvSkladTable.Rows[i].Cells[2].Value;
                    sqlCommand.Parameters.Add("@nalichie", SqlDbType.Int).Value = dgvSkladTable.Rows[i].Cells[3].Value;
                    sqlCommand.Parameters.Add("@EdIzm", SqlDbType.VarChar).Value = dgvSkladTable.Rows[i].Cells[4].Value;
                    if (sqlCommand.ExecuteNonQuery() == 1)
                    {
                        label5.Text = "";
                    }
                    dataBase.closeConnection();
                }
            }
            MessageBox.Show("Изменения были успешно сохранены");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            DataBase dataBase = new DataBase();
            string script = "SELECT НомерЗапчасти, Название AS [Название запчасти], Цена, НаличиеНаСкладе AS [Наличие на складе], ЕдИзмерения AS [ШТ/Л] FROM Запчасть";
            SqlDataAdapter adapter = new SqlDataAdapter(script, dataBase.getConnection());
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvSkladTable.DataSource = dataTable;
            this.dgvSkladTable.Columns["НомерЗапчасти"].Visible = false;
        }
    }
}
