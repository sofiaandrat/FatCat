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

namespace FatCat
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Registration form = new Registration();
            form.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            if (User_name.Text == "admin")
            {
                Visibility = 0;
                Admin_s_main admin_S_Main = new Admin_s_main();
                admin_S_Main.Show();
            }
            if (User_name.Text == "tester")
            {
                Visibility = 0;
                Bowl_s_control bowl_S_Control = new Bowl_s_control();
                bowl_S_Control.Show();
            }
            if (User_name.Text != "admin" && User_name.Text != "tester")
            {
                Visibility = 0;
                Bowl_s_control bowl_S_Control = new Bowl_s_control();
                bowl_S_Control.Show();
            }

        }
    }
}
