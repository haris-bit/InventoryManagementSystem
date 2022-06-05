using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace InventoryManagementSystem
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        static string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\Downloads\ead_work\InventoryManagementSystem\InventoryManagementSystem\InventoryManagementSystem\Database1.mdf;Integrated Security=True";
        public Window1()
        {
            InitializeComponent();
        }

        private void userNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(cs);


            String userName = userNameTextBox.Text.Trim();
            String passWord = passwordTextBox.Text.Trim();

            string query = "Select * from Accounts Where Username = '" + userName + "' and Password = '" + passWord + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, cs);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                MainWindow mainWindow = new MainWindow();
                this.Hide();
                mainWindow.Show();
            } else
            {
                MessageBox.Show("Check your Username and Password");
            }
 
         
        }
    }
}
