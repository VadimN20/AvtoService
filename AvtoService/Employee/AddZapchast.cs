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
    public partial class AddZapchast : Form
    {
        public AddZapchast()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            dataBase.openConnection();
            string script = "INSERT INTO Запчасть (Название, Цена, НаличиеНаСкладе, ЕдИзмерения) VALUES (@names, @price, @sklad, @EdIzmer)";
            SqlCommand sqlCommand = new SqlCommand(script, dataBase.getConnection());
            sqlCommand.Parameters.Add("@names", SqlDbType.VarChar).Value = searchText1.Text;
            sqlCommand.Parameters.Add("@price", SqlDbType.Int).Value = searchNum1.Text;
            sqlCommand.Parameters.Add("@sklad", SqlDbType.Int).Value = searchNum2.Text;
            sqlCommand.Parameters.Add("@EdIzmer", SqlDbType.VarChar).Value = comboBox1.Text;

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
