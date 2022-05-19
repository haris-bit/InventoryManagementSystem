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
    /// Interaction logic for DeleteWindow.xaml
    /// </summary>
    public partial class DeleteWindow : Window
    {
        public DeleteWindow()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\Downloads\ead_work\InventoryManagementSystem\InventoryManagementSystem\InventoryManagementSystem\Database1.mdf;Integrated Security=True");

        public void clearData()
        {
            search_txt.Clear();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Product WHERE ID = " + search_txt.Text + " ", con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record has been deleted successfully", "Deleted", MessageBoxButton.OK, MessageBoxImage.Information);
                    con.Close();
                    clearData();
                    con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Not Deleted: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
        }

        private void search_txt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}