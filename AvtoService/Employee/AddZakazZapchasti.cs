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
    public partial class AddZakazZapchasti : Form
    {
        public AddZakazZapchasti()
        {
            InitializeComponent();

            DataBase dataBase = new DataBase();
            string script = "SELECT Название AS Snazvan, НомерЗапчасти AS Snomer FROM Запчасть ORDER BY Название";
            SqlCommand sqlCommand = new SqlCommand(script, dataBase.getConnection());
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = "Snazvan";
            comboBox1.ValueMember = "Snomer";

            dataBase.openConnection();
            string script1 = "SELECT MAX(НомерЗаказа) FROM ЗаказНаЗакупкуЗапчастей";
            SqlCommand sqlCommand1 = new SqlCommand(script1, dataBase.getConnection());
            textBox1.Text = (int.Parse(sqlCommand1.ExecuteScalar().ToString()) + 1).ToString();
            dataBase.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int dostavka = random.Next(1, 25);

            int idZapchasti;
            int idSostava;
            int price;

            DataBase dataBase = new DataBase();
            dataBase.openConnection();
            string script1 = "SELECT Цена FROM Запчасть WHERE НомерЗапчасти=@nomer";
            SqlCommand sqlCommand1 = new SqlCommand(script1, dataBase.getConnection());
            sqlCommand1.Parameters.Add("@nomer", SqlDbType.Int).Value = (int)(comboBox1.SelectedValue);
            price = int.Parse(sqlCommand1.ExecuteScalar().ToString());
            dataBase.closeConnection();
            price = price * (int)(numericUpDown1.Value);

            dataBase.openConnection();
            string script3 = "SELECT MAX(IdЗапчастиНарядЗаказа) FROM ЗапчастьНарядЗаказа";
            SqlCommand sqlCommand3 = new SqlCommand(script3, dataBase.getConnection());
            idZapchasti = int.Parse(sqlCommand3.ExecuteScalar().ToString()) + 1;
            dataBase.closeConnection();

            dataBase.openConnection();
            string script4 = "SELECT MAX(IdСоставаЗаказаНаЗакупку) FROM СоставЗаказаНаЗакупку";
            SqlCommand sqlCommand4 = new SqlCommand(script4, dataBase.getConnection());
            idSostava = int.Parse(sqlCommand4.ExecuteScalar().ToString()) + 1;
            dataBase.closeConnection();



            dataBase.openConnection();
            string script = "INSERT INTO ЗаказНаЗакупкуЗапчастей (IdСотрудника, ЦенаНаЗаказ, ВремяДоставки, КоличествоПозиций) VALUES (@idSotr, @price, @dostavka, @kolvo)";
            SqlCommand sqlCommand = new SqlCommand(script, dataBase.getConnection());
            sqlCommand.Parameters.Add("@idSotr", SqlDbType.VarChar).Value = DataForUsing.passSotr;
            sqlCommand.Parameters.Add("@price", SqlDbType.Int).Value = price;
            sqlCommand.Parameters.Add("@dostavka", SqlDbType.Int).Value = dostavka;
            sqlCommand.Parameters.Add("@kolvo", SqlDbType.Int).Value = numericUpDown1.Value;

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

            dataBase.openConnection();
            string script2 = "INSERT INTO ЗапчастьНарядЗаказа (IdЗапчастиНарядЗаказа, НомерНарядЗаказа, НомерЗапчасти, Количество) VALUES (@idZap, @nomerZakaza, @nomerZap, @kolvo)";
            SqlCommand sqlCommand2 = new SqlCommand(script2, dataBase.getConnection());
            sqlCommand2.Parameters.Add("@idZap", SqlDbType.Int).Value = idZapchasti;
            sqlCommand2.Parameters.Add("@nomerZakaza", SqlDbType.Int).Value = textBox1.Text;
            sqlCommand2.Parameters.Add("@nomerZap", SqlDbType.Int).Value = (int)comboBox1.SelectedValue;
            sqlCommand2.Parameters.Add("@kolvo", SqlDbType.Int).Value = numericUpDown1.Value;

            if (sqlCommand2.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Данные успешно сохранены");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Данные не сохранились");
            }
            dataBase.closeConnection();

            dataBase.openConnection();
            string script5 = "INSERT INTO СоставЗаказаНаЗакупку (IdСоставаЗаказаНаЗакупку, НомерЗаказа, НомерЗапчасти, Количество, ЕдиницаИзмирения) VALUES (@idSostava, @nomerZakaza, @nomerZap,  @kolvo, (SELECT ЕдИзмерения FROM Запчасть WHERE Запчасть.НомерЗапчасти = @nomerZap))";
            SqlCommand sqlCommand5 = new SqlCommand(script5, dataBase.getConnection());
            sqlCommand5.Parameters.Add("@idSostava", SqlDbType.Int).Value = idSostava;
            sqlCommand5.Parameters.Add("@nomerZakaza", SqlDbType.Int).Value = textBox1.Text;
            sqlCommand5.Parameters.Add("@nomerZap", SqlDbType.Int).Value = (int)comboBox1.SelectedValue;
            sqlCommand5.Parameters.Add("@kolvo", SqlDbType.Int).Value = numericUpDown1.Value;

            if (sqlCommand5.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Данные успешно сохранены ");
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
