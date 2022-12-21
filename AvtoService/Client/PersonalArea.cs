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

namespace AvtoService.Client
{
    public partial class PersonalArea : Form
    {
        public PersonalArea()
        {
            InitializeComponent();
           
            DataBase dataBase = new DataBase();
            SqlCommand command = new SqlCommand("SELECT * FROM Клиент WHERE ПаспортныеДанные = @passport", dataBase.getConnection());
            command.Parameters.Add("@passport", SqlDbType.VarChar).Value = DataForUsing.loginUser.ToString();
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;


            textBox1.Text = dataGridView1[1, 0].Value.ToString();

            textBox2.Text = DataForUsing.loginUser;
            textBox3.Text = DataForUsing.passUser;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            dataBase.openConnection();
            string script = "UPDATE Клиент SET ФИО = @fio, ПаспортныеДанные = @passport, НомерТелефона = @phNumber WHERE IdКлиента = @idClient";
            SqlCommand sqlCommand = new SqlCommand(script, dataBase.getConnection());
            sqlCommand.Parameters.Add("@fio", SqlDbType.VarChar).Value = textBox1.Text;
            sqlCommand.Parameters.Add("@passport", SqlDbType.VarChar).Value = textBox2.Text;
            DataForUsing.loginUser = textBox2.Text;
            sqlCommand.Parameters.Add("@phNumber", SqlDbType.VarChar).Value = textBox3.Text;
            sqlCommand.Parameters.Add("@idClient", SqlDbType.Int).Value = dataGridView1[0, 0].Value;
            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Сохранено");
            }
            dataBase.closeConnection();
        }
    }
}
