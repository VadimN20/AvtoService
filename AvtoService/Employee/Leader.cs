using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvtoService.Employee
{
    public partial class Leader : Form
    {
        public Leader()
        {
            InitializeComponent();
            btnUpdateSotr.Visible = false;

            dgvLeaderTable.RowHeadersVisible = false;
            dgvLeaderTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLeaderTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLeaderTable.AllowUserToAddRows = false;
            dgvLeaderTable.AllowUserToResizeColumns = false;
            dgvLeaderTable.AllowUserToResizeRows = false;

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;

            DataBase dataBase = new DataBase();
            string script = "SELECT IdСотрудника AS [Id Сотрудника], ФИО, НомерТелефона AS [Номер телефона], Стаж, Зарплата FROM Сотрудник";
            SqlDataAdapter adapter = new SqlDataAdapter(script, dataBase.getConnection());
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvLeaderTable.DataSource = dataTable;

            dataBase.openConnection();
            string script1 = "SELECT ФИО FROM Сотрудник WHERE IdСотрудника=@login";
            SqlCommand sqlCommand = new SqlCommand(script1, dataBase.getConnection());
            sqlCommand.Parameters.Add("@login", SqlDbType.Int).Value = int.Parse(DataForUsing.passSotr);
            label7.Text = sqlCommand.ExecuteScalar().ToString();
            dataBase.closeConnection();

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label8.Visible = false;

            searchNum1.Visible = false;
            searchText1.Visible = false;
            searchText2.Visible = false;
            searchNum2.Visible = false;

            btnDelSotr.Visible = false;
            btnUpdateSotr.Visible = false;
            dgvLeaderTable.Visible = false;
            dgvLeaderTable.Height = 340;
            dataGridView1.Visible = false;

        }

        private void btnShowSotrs_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
            label8.Visible = false;
            label1.Text = "Id Сотрудника";
            label2.Text = "ФИО";
            label3.Text = "Номер телефона";
            label4.Text = "Стаж";
            searchNum1.Visible = true;
            searchText1.Visible = true;
            searchText2.Visible = true;
            searchNum2.Visible = true;

            btnDelSotr.Visible = true;
            btnUpdateSotr.Visible = true;

            dgvLeaderTable.Visible = true;
            dgvLeaderTable.Height = 340;
            dataGridView1.Visible = false;

            DataBase dataBase = new DataBase();
            string script = "SELECT IdСотрудника AS [Id Сотрудника], ФИО, НомерТелефона AS [Номер телефона], Стаж, Зарплата FROM Сотрудник";
            SqlCommand sqlCommand = new SqlCommand(script, dataBase.getConnection());
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            dgvLeaderTable.DataSource = dataTable;
            dgvLeaderTable.Columns["Id Сотрудника"].ReadOnly = true;
            btnUpdateSotr.Visible = true;
        }

        private void btnAddSotr_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dgvLeaderTable.Height = 340;
            label5.Visible = false;
            label8.Visible = false;

            AddEmployee regSotr = new AddEmployee();
            regSotr.ShowDialog();
        }

        private void btnDelSotr_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dgvLeaderTable.Height = 340;
            label5.Visible = false;
            label8.Visible = false;
            try
            {
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите уволить сотрудника?", "Подтверждение на увольнение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    
                    DataBase dataBase = new DataBase();
                    SqlCommand command = new SqlCommand("UPDATE Сотрудник SET Зарплата = 0 WHERE IdСотрудника=@idSotr", dataBase.getConnection());
                    command.Parameters.Add("@idSotr", SqlDbType.Int).Value = dgvLeaderTable.SelectedRows[0].Cells["Id Сотрудника"].Value.ToString();
                    dataBase.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        dgvLeaderTable.DataSource = null;
                        MessageBox.Show("Сотрудник уволен");
                        string script = "SELECT IdСотрудника AS [Id Сотрудника], ФИО, НомерТелефона AS [Номер телефона], Стаж, Зарплата FROM Сотрудник";
                        SqlDataAdapter adapter = new SqlDataAdapter(script, dataBase.getConnection());
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvLeaderTable.DataSource = dataTable;
                    }
                    else
                        MessageBox.Show("Сотрудник не найден");

                    dataBase.closeConnection();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Сотрудника нет");
                return;
            }
        }

        private void btnUpdateSotr_Click(object sender, EventArgs e)
        {
            btnUpdateSotr.Visible = true;
            dataGridView1.Visible = false;
            dgvLeaderTable.Height = 340;
            label5.Visible = false;
            label8.Visible = false;

            for (int i = 0; i < dgvLeaderTable.Rows.Count; i++)
            {
                for (int j = 0; j < dgvLeaderTable.Columns.Count; j++)
                {
                    DataBase dataBase = new DataBase();
                    dataBase.openConnection();
                    string script = "UPDATE Сотрудник SET ФИО = @fio, НомерТелефона = @phNumber, Стаж = @stage, Зарплата = @salary WHERE IdСотрудника = @idSotr";
                    SqlCommand sqlCommand = new SqlCommand(script, dataBase.getConnection());
                    sqlCommand.Parameters.Add("@idSotr", SqlDbType.Int).Value = dgvLeaderTable.Rows[i].Cells[0].Value;
                    sqlCommand.Parameters.Add("@fio", SqlDbType.VarChar).Value = dgvLeaderTable.Rows[i].Cells[1].Value;
                    sqlCommand.Parameters.Add("@phNumber", SqlDbType.VarChar).Value = dgvLeaderTable.Rows[i].Cells[2].Value;
                    sqlCommand.Parameters.Add("@stage", SqlDbType.Int).Value = dgvLeaderTable.Rows[i].Cells[3].Value;
                    sqlCommand.Parameters.Add("@salary", SqlDbType.Int).Value = dgvLeaderTable.Rows[i].Cells[4].Value;
                    if (sqlCommand.ExecuteNonQuery() == 1)
                    {
                        label6.Text = "Руководство";
                    }
                    dataBase.closeConnection();
                }
            }
        }

        private void btnShowSostavZakazov_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = true;
            label8.Visible = true;

            searchNum1.Visible = false;
            searchText1.Visible = false;
            searchText2.Visible = false;
            searchNum2.Visible = false;

            btnDelSotr.Visible = false;
            btnUpdateSotr.Visible = false;
            dgvLeaderTable.Visible = true;
            dataGridView1.Visible = true;

            btnDelSotr.Visible = false;
            btnUpdateSotr.Visible = false;

            dgvLeaderTable.Height = 190;

            DataBase dataBase = new DataBase();
            string script = "SELECT НомерЗаказа AS [Номер заказа], (SELECT ФИО FROM Сотрудник WHERE (ЗаказНаЗакупкуЗапчастей.IdСотрудника = Сотрудник.IdСотрудника)) AS [ФИО сотрудника], ЦенаНаЗаказ AS [Цена на заказ], ВремяДоставки AS [Время доставки(Дней)], КоличествоПозиций AS [Количество позиций] FROM ЗаказНаЗакупкуЗапчастей";
            SqlCommand sqlCommand = new SqlCommand(script, dataBase.getConnection());
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            dgvLeaderTable.DataSource = dataTable;
            dgvLeaderTable.ReadOnly = true;

            string script1 = "SELECT IdСоставаЗаказаНаЗакупку AS [Id Состава заказа на закупку], НомерЗаказа AS [Номер заказа], (SELECT Название FROM Запчасть WHERE (СоставЗаказаНаЗакупку.НомерЗапчасти = Запчасть.НомерЗапчасти)) AS [Название запчасти], Количество, ЕдиницаИзмирения AS [ШТ/Л] FROM СоставЗаказаНаЗакупку";
            SqlCommand sqlCommand1 = new SqlCommand(script1, dataBase.getConnection());
            DataTable dataTable1 = new DataTable();
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlCommand1);
            sqlDataAdapter1.Fill(dataTable1);
            dataGridView1.DataSource = dataTable1;
            dataGridView1.ReadOnly = true;
        }

        private void PhoneNumText_TextChanged_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            label5.Visible = false;
            label8.Visible = false;

            (dgvLeaderTable.DataSource as DataTable).DefaultView.RowFilter = $"[Номер телефона] LIKE '%{searchText2.Text}%'";
            if (searchText2.Text == "Номер телефона")
            {
                DataBase dataBase = new DataBase();
                string script = "SELECT IdСотрудника AS [Id Сотрудника], ФИО, НомерТелефона AS [Номер телефона], Стаж, Зарплата FROM Сотрудник";
                SqlDataAdapter adapter = new SqlDataAdapter(script, dataBase.getConnection());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvLeaderTable.DataSource = dataTable;
            }

        }

        private void searchNum1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dgvLeaderTable.Height = 340;
            label5.Visible = false;
            label8.Visible = false;

            (dgvLeaderTable.DataSource as DataTable).DefaultView.RowFilter = $"[Id Сотрудника] = " + searchNum1.Value.ToString();
            if (searchNum1.Value == 1120)
            {
                DataBase dataBase = new DataBase();
                string script = "SELECT IdСотрудника AS [Id Сотрудника], ФИО, НомерТелефона AS [Номер телефона], Стаж, Зарплата FROM Сотрудник";
                SqlDataAdapter adapter = new SqlDataAdapter(script, dataBase.getConnection());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvLeaderTable.DataSource = dataTable;
            }
        }

        private void StageNum_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dgvLeaderTable.Height = 340;
            label5.Visible = false;
            label8.Visible = false;

            (dgvLeaderTable.DataSource as DataTable).DefaultView.RowFilter = $"[Стаж] = " + searchNum2.Value.ToString();
            if (searchNum2.Value == 0)
            {
                DataBase dataBase = new DataBase();
                string script = "SELECT IdСотрудника AS [Id Сотрудника], ФИО, НомерТелефона AS [Номер телефона], Стаж, Зарплата FROM Сотрудник";
                SqlDataAdapter adapter = new SqlDataAdapter(script, dataBase.getConnection());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvLeaderTable.DataSource = dataTable;
            }
        }

        private void FIO_Text_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dgvLeaderTable.Height = 340;
            label5.Visible = false;
            label8.Visible = false;

            (dgvLeaderTable.DataSource as DataTable).DefaultView.RowFilter = $"[ФИО] LIKE '%{searchText1.Text}%'";
            if (searchText1.Text == "")
            {
                DataBase dataBase = new DataBase();
                string script = "SELECT IdСотрудника AS [Id Сотрудника], ФИО, НомерТелефона AS [Номер телефона], Стаж, Зарплата FROM Сотрудник";
                SqlDataAdapter adapter = new SqlDataAdapter(script, dataBase.getConnection());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvLeaderTable.DataSource = dataTable;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label8.Visible = false;

            searchNum1.Visible = false;
            searchText1.Visible = false;
            searchText2.Visible = false;
            searchNum2.Visible = false;

            btnDelSotr.Visible = false;
            btnUpdateSotr.Visible = false;
            dgvLeaderTable.Visible = false;
            dataGridView1.Visible = false;

            LeaderShowSklad leaderShowSklad = new LeaderShowSklad();
            leaderShowSklad.ShowDialog();
        }
    }
}