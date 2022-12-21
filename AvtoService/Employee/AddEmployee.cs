using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvtoService.Employee
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            dataBase.openConnection();
            string script = "INSERT INTO Сотрудник (IdСотрудника, ФИО, НомерТелефона, Стаж, Зарплата) VALUES (@idSotr, @lastname + ' ' + @name + ' ' + @surname, @phNumber, @stage, @salary)";
            SqlCommand sqlCommand = new SqlCommand(script, dataBase.getConnection());
            sqlCommand.Parameters.Add("@idSotr", SqlDbType.Int).Value = textBox1.Text;
            sqlCommand.Parameters.Add("@name", SqlDbType.VarChar).Value = textBox6.Text;
            sqlCommand.Parameters.Add("@surname", SqlDbType.VarChar).Value = textBox5.Text;
            sqlCommand.Parameters.Add("@lastname", SqlDbType.VarChar).Value = textBox7.Text;
            sqlCommand.Parameters.Add("@phNumber", SqlDbType.VarChar).Value = textBox2.Text;
            sqlCommand.Parameters.Add("@salary", SqlDbType.Int).Value = textBox3.Text;
            sqlCommand.Parameters.Add("@stage", SqlDbType.Int).Value = numericUpDown1.Text;
            
            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Данные успешно сохранены");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Данные не сохранились");
            }
            dataBase.closeConnection();
        }
    }
}
