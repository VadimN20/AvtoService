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
    public partial class AddZakazRabota : Form
    {
        public AddZakazRabota()
        {
            InitializeComponent();
            DataBase dataBase = new DataBase();
            string script = "SELECT ФИО AS Sfio, IdКлиента AS Sid FROM Клиент ORDER BY ФИО";
            SqlCommand sqlCommand = new SqlCommand(script, dataBase.getConnection());
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            comboBoxFio.DataSource = dataTable;
            comboBoxFio.DisplayMember = "Sfio";
            comboBoxFio.ValueMember = "Sid";

            string script3 = "SELECT Название AS nZap, НомерЗапчасти AS nomZap FROM Запчасть ORDER BY Название";
            SqlCommand sqlCommand3 = new SqlCommand(script3, dataBase.getConnection());
            DataTable dataTable3 = new DataTable();
            SqlDataAdapter sqlDataAdapter3 = new SqlDataAdapter(sqlCommand3);
            sqlDataAdapter3.Fill(dataTable3);
            comboBox2.DataSource = dataTable3;
            comboBox2.DisplayMember = "nZap";
            comboBox2.ValueMember = "nomZap";

            dataBase.openConnection();
            string script1 = "SELECT MAX(НомерНарядЗаказа) FROM НарядЗаказ";
            SqlCommand sqlCommand1 = new SqlCommand(script1, dataBase.getConnection());
            textBox5.Text = (int.Parse(sqlCommand1.ExecuteScalar().ToString()) + 1).ToString();
            dataBase.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (numericUpDown2.Value == 0 || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.SelectedText.Length < 0 || comboBoxFio.SelectedText.Length < 0)
            {
                label12.Text = "Не все поля заполнены!";
            }
            else
            {
                DataBase dataBase = new DataBase();
                dataBase.openConnection();
                string script = "INSERT INTO НарядЗаказ (НомерНарядЗаказа, IdКлиента, ДатаОформления, ДатаИсполнения, Гарантия, СтатусОплаты, ГосНомер, VINКод, Цвет, МаркаМашины) VALUES (@numZakaz, @IdClient, @dat1, @dat2, @garant, @status, @gosNum, @vin, @color, @car)";
                SqlCommand sqlCommand = new SqlCommand(script, dataBase.getConnection());
                sqlCommand.Parameters.Add("@numZakaz", SqlDbType.Int).Value = int.Parse(textBox5.Text);
                sqlCommand.Parameters.Add("@idClient", SqlDbType.Int).Value = (int)comboBoxFio.SelectedValue;
                sqlCommand.Parameters.Add("@dat1", SqlDbType.Date).Value = dateTimePicker1.Value;
                sqlCommand.Parameters.Add("@dat2", SqlDbType.Date).Value = dateTimePicker2.Value;
                sqlCommand.Parameters.Add("@garant", SqlDbType.Int).Value = numericUpDown2.Value;
                sqlCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = comboBox1.Text;
                sqlCommand.Parameters.Add("@gosNum", SqlDbType.VarChar).Value = textBox1.Text;
                sqlCommand.Parameters.Add("@vin", SqlDbType.VarChar).Value = textBox2.Text;
                sqlCommand.Parameters.Add("@color", SqlDbType.VarChar).Value = textBox3.Text;
                sqlCommand.Parameters.Add("@car", SqlDbType.VarChar).Value = textBox4.Text;

                string script1 = "INSERT INTO СотрудникНарядЗаказ (НомерНарядЗаказа, IdСотрудника, ВидРабот) VALUES (@numZakaz, @IdSotr, @VidRabot)";
                SqlCommand sqlCommand1 = new SqlCommand(script1, dataBase.getConnection());
                sqlCommand1.Parameters.Add("@numZakaz", SqlDbType.Int).Value = int.Parse(textBox5.Text);
                sqlCommand1.Parameters.Add("@IdSotr", SqlDbType.Int).Value = DataForUsing.passSotr;
                if (textBox6.Text == "")
                {
                    sqlCommand1.Parameters.Add("@VidRabot", SqlDbType.VarChar).Value = "Диагностика".ToString();
                }
                else
                {
                    sqlCommand1.Parameters.Add("@VidRabot", SqlDbType.VarChar).Value = textBox6.Text;
                }
                //sqlCommand1.Parameters.Add("@dat1", SqlDbType.Date).Value = dateTimePicker1.Value;


                string script2 = "INSERT INTO ЗапчастьНарядЗаказа (IdЗапчастиНарядЗаказа, НомерНарядЗаказа, НомерЗапчасти, Количество) VALUES ((SELECT MAX(IdЗапчастиНарядЗаказа) FROM ЗапчастьНарядЗаказа) + 1, @numZakaz, @zap, 1)";
                SqlCommand sqlCommand2 = new SqlCommand(script2, dataBase.getConnection());
                sqlCommand2.Parameters.Add("@numZakaz", SqlDbType.Int).Value = int.Parse(textBox5.Text);
                if (textBox6.Text == "")
                {
                    sqlCommand2.Parameters.Add("@zap", SqlDbType.Int).Value = 10014;
                }
                else {
                    sqlCommand2.Parameters.Add("@zap", SqlDbType.Int).Value = (int)comboBox2.SelectedValue;
                }

                if (sqlCommand.ExecuteNonQuery() == 1 && sqlCommand1.ExecuteNonQuery() == 1 && sqlCommand2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные о наряд заказе успешно сохранены");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Данные не сохранились");
                }

                /*
                if (sqlCommand1.ExecuteNonQuery() == 1)

                {
                    MessageBox.Show("Данные о наряд заказе успешно сохранены");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Данные не сохранились");
                }

                if (sqlCommand2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные о запчасти успешно сохранены");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Данные не сохранились");
                }*/

                dataBase.closeConnection();
            }
        }

    }
}
