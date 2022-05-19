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
    /// Interaction logic for UpdateWindow.xaml
    /// </summary>
    public partial class UpdateWindow : Window
    {
        public UpdateWindow()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\Downloads\ead_work\InventoryManagementSystem\InventoryManagementSystem\InventoryManagementSystem\Database1.mdf;Integrated Security=True");

        public void clearData()
        {
            name_txt.Clear();
            price_txt.Clear();
            quantity_txt.Clear();
            search_txt.Clear();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Product SET Name = '" + name_txt.Text + "', Price = '" + price_txt.Text + "', Quantity = '" + quantity_txt.Text + "' WHERE ID = '" + search_txt.Text + "' ", con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record has been updated successsfully", "Updated", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    clearData();
                }
        }

    }
}
