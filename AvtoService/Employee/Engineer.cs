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

namespace AvtoService.Employee
{
    public partial class Engineer : Form
    {
        public Engineer()
        {
            InitializeComponent();

            label2.Text = "План работ:";
            button6.Visible = false;
            button4.Visible = false;

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = true;
            dataGridView1.AllowUserToResizeRows = false;

            DataBase dataBase = new DataBase();
            dataBase.openConnection();
            string script1 = "SELECT IdСотрудника FROM Сотрудник WHERE НомерТелефона=@login";
            SqlCommand sqlCommand = new SqlCommand(script1, dataBase.getConnection());
            sqlCommand.Parameters.Add("@login", SqlDbType.VarChar).Value = DataForUsing.loginSotr;
            string script = "SELECT IdНомерСотрудникНарядЗаказа AS [ID Наряд Заказа Сотрудника], НомерНарядЗаказа AS [Номер наряд заказа], ВидРабот AS [Вид работ], ДатаРемонта AS [Дата ремонта] FROM СотрудникНарядЗаказ WHERE IdСотрудника = @IdSotr";
            SqlCommand sqlCommand1 = new SqlCommand(script, dataBase.getConnection());
            sqlCommand1.Parameters.Add("@IdSotr", SqlDbType.VarChar).Value = sqlCommand.ExecuteScalar().ToString();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand1);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataBase.closeConnection();

            dataBase.openConnection();
            string script2 = "SELECT ФИО FROM Сотрудник WHERE IdСотрудника=@pass";
            SqlCommand sqlCommand2 = new SqlCommand(script2, dataBase.getConnection());
            sqlCommand2.Parameters.Add("@pass", SqlDbType.Int).Value = int.Parse(DataForUsing.passSotr);
            label3.Text = sqlCommand2.ExecuteScalar().ToString();
            dataBase.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "План работ:";
            button6.Visible = false;
            button4.Visible = false;
            AddZakazRabota addZakazRabota = new AddZakazRabota();
            addZakazRabota.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "План работ:";
            button6.Visible = false;
            button4.Visible = false;
            AddZakazZapchasti addZakazZapchasti = new AddZakazZapchasti();
            addZakazZapchasti.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "План работ:";
            button6.Visible = false;
            button4.Visible = true;

            DataBase dataBase = new DataBase();
            dataBase.openConnection();
            string script1 = "SELECT IdСотрудника FROM Сотрудник WHERE НомерТелефона=@login";
            SqlCommand sqlCommand = new SqlCommand(script1, dataBase.getConnection());
            sqlCommand.Parameters.Add("@login", SqlDbType.VarChar).Value = DataForUsing.loginSotr;
            string script = "SELECT IdНомерСотрудникНарядЗаказа AS [ID Наряд Заказа Сотрудника], НомерНарядЗаказа AS [Номер наряд заказа], ВидРабот AS [Вид работ], ДатаРемонта AS [Дата ремонта] FROM СотрудникНарядЗаказ WHERE IdСотрудника = @IdSotr";
            SqlCommand sqlCommand1 = new SqlCommand(script, dataBase.getConnection());
            sqlCommand1.Parameters.Add("@IdSotr", SqlDbType.VarChar).Value = sqlCommand.ExecuteScalar().ToString();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand1);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataBase.closeConnection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idNomerNaryadZakaza;
            int idNomerZapchasti;
            int kolvo;
            label2.Text = "План работ:";
            button6.Visible = false;
            button4.Visible = false;

            DataBase dataBase = new DataBase();
            dataBase.openConnection();
            SqlCommand sqlcommand = new SqlCommand("SELECT НомерНарядЗаказа FROM СотрудникНарядЗаказ WHERE IdНомерСотрудникНарядЗаказа = @idSotr", dataBase.getConnection());
            sqlcommand.Parameters.Add("@idSotr", SqlDbType.Int).Value = int.Parse(dataGridView1.SelectedRows[0].Cells["ID Наряд Заказа Сотрудника"].Value.ToString());
            idNomerNaryadZakaza = int.Parse(sqlcommand.ExecuteScalar().ToString());

            SqlCommand sqlcommand1 = new SqlCommand("SELECT НомерЗапчасти FROM ЗапчастьНарядЗаказа WHERE НомерНарядЗаказа = @idNomerZakaza", dataBase.getConnection());
            sqlcommand1.Parameters.Add("@idNomerZakaza", SqlDbType.Int).Value = idNomerNaryadZakaza;
            idNomerZapchasti = int.Parse(sqlcommand1.ExecuteScalar().ToString());

            SqlCommand sqlcommand2 = new SqlCommand("SELECT Количество FROM ЗапчастьНарядЗаказа WHERE НомерНарядЗаказа = @idNomerZakaza", dataBase.getConnection());
            sqlcommand2.Parameters.Add("@idNomerZakaza", SqlDbType.Int).Value = idNomerNaryadZakaza;
            kolvo = int.Parse(sqlcommand2.ExecuteScalar().ToString());


            SqlCommand sqlcommand3 = new SqlCommand("UPDATE Запчасть SET НаличиеНаСкладе = НаличиеНаСкладе - @kolvo WHERE НомерЗапчасти = @idNomerZap", dataBase.getConnection());
            sqlcommand3.Parameters.Add("@kolvo", SqlDbType.Int).Value = kolvo;
            sqlcommand3.Parameters.Add("@idNomerZap", SqlDbType.Int).Value = idNomerZapchasti;

            sqlcommand3.ExecuteNonQuery();

            SqlCommand command = new SqlCommand("UPDATE СотрудникНарядЗаказ SET ДатаРемонта = @vipol WHERE НомерНарядЗаказа=@IdNomer", dataBase.getConnection());
            command.Parameters.Add("@IdNomer", SqlDbType.Int).Value = idNomerNaryadZakaza;
            command.Parameters.Add("@vipol", SqlDbType.Date).Value = dateTimePicker1.Value;
            dataBase.openConnection();

            command.ExecuteNonQuery();

            dataBase.closeConnection();          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "Список доставок:";
            button6.Visible = true;
            button4.Visible = false;

            DataBase dataBase = new DataBase();
            string script = "SELECT НомерЗаказа AS [Номер заказа], (SELECT ФИО FROM Сотрудник WHERE Сотрудник.IdСотрудника = ЗаказНаЗакупкуЗапчастей.IdСотрудника) AS [ФИО], ЦенаНаЗаказ AS [Цена на заказ], ВремяДоставки AS [Время доставки], КоличествоПозиций AS [Количество позиций] FROM ЗаказНаЗакупкуЗапчастей";
            SqlDataAdapter adapter = new SqlDataAdapter(script, dataBase.getConnection());
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int nomerZap;
            int kolvoZap;
            button6.Visible = false;
            button4.Visible = false;

            DataBase dataBase = new DataBase();
            dataBase.openConnection();

            SqlCommand command4 = new SqlCommand("SELECT Количество FROM СоставЗаказаНаЗакупку WHERE НомерЗаказа = @idNomer", dataBase.getConnection());
            command4.Parameters.Add("@idNomer", SqlDbType.Int).Value = dataGridView1.SelectedRows[0].Cells["Номер заказа"].Value.ToString();
            kolvoZap = int.Parse(command4.ExecuteScalar().ToString());

            SqlCommand command3 = new SqlCommand("SELECT НомерЗапчасти FROM СоставЗаказаНаЗакупку WHERE НомерЗаказа = @idNomer", dataBase.getConnection());
            command3.Parameters.Add("@idNomer", SqlDbType.Int).Value = dataGridView1.SelectedRows[0].Cells["Номер заказа"].Value.ToString();
            nomerZap = int.Parse(command3.ExecuteScalar().ToString());

            SqlCommand command2 = new SqlCommand("UPDATE Запчасть SET НаличиеНаСкладе = НаличиеНаСкладе + @kolvo WHERE НомерЗапчасти=@idZap", dataBase.getConnection());
            command2.Parameters.Add("@idZap", SqlDbType.Int).Value = nomerZap;
            command2.Parameters.Add("@kolvo", SqlDbType.Int).Value = kolvoZap;

            command2.ExecuteNonQuery();

            SqlCommand command1 = new SqlCommand("DELETE FROM СоставЗаказаНаЗакупку WHERE НомерЗаказа=@IdNomer", dataBase.getConnection());
            command1.Parameters.Add("@IdNomer", SqlDbType.Int).Value = dataGridView1.SelectedRows[0].Cells["Номер Заказа"].Value.ToString();

            command1.ExecuteNonQuery();

            SqlCommand command = new SqlCommand("DELETE FROM ЗаказНаЗакупкуЗапчастей WHERE НомерЗаказа=@IdNomer", dataBase.getConnection());
            command.Parameters.Add("@IdNomer", SqlDbType.Int).Value = dataGridView1.SelectedRows[0].Cells["Номер Заказа"].Value.ToString();

            command.ExecuteNonQuery();

            dataBase.closeConnection();
            
            string script = "SELECT НомерЗаказа AS [Номер заказа], (SELECT ФИО FROM Сотрудник WHERE Сотрудник.IdСотрудника = ЗаказНаЗакупкуЗапчастей.IdСотрудника) AS [ФИО], ЦенаНаЗаказ AS [Цена на заказ], ВремяДоставки AS [Время доставки], КоличествоПозиций AS [Количество позиций] FROM ЗаказНаЗакупкуЗапчастей";
            SqlDataAdapter adapter = new SqlDataAdapter(script, dataBase.getConnection());
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
