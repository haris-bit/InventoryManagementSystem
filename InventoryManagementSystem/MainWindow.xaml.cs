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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace InventoryManagementSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\Downloads\ead_work\InventoryManagementSystem\InventoryManagementSystem\InventoryManagementSystem\Database1.mdf;Integrated Security=True";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            var window = new ViewWindow();
            window.ShowDialog();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            var window = new InsertWindow();
            window.ShowDialog();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            var window = new UpdateWindow();
            window.ShowDialog();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var window = new DeleteWindow();
            window.ShowDialog();
        }
    }
}
