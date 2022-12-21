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
    public partial class DeleteEmployee : Form
    {
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить клиента?", "Подтверждение на удаление клиента", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                { 
                    DataBase dataBase = new DataBase();
                    SqlCommand command = new SqlCommand("DELETE FROM Сотрудник WHERE IdСотрудника=@IdSotr", dataBase.getConnection());
                    command.Parameters.Add("@IdSotr", SqlDbType.Int).Value = tBIdEmployee.Text;
                    dataBase.openConnection();

                    command.ExecuteNonQuery();
                    MessageBox.Show("Сотрудник удалён");
                    dataBase.closeConnection();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Такого сотрудника нет");
                return;
            }
        }
    }
}
