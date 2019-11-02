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

namespace FatCat
{
    /// <summary>
    /// Логика взаимодействия для Bowl_s_control.xaml
    /// </summary>
    public partial class Bowl_s_control : Window
    {
        public Bowl_s_control()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manual_feeding manual_Feeding = new Manual_feeding;
            manual_Feeding.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Create_a_cat_s_diet create_A_Cat_S_Diet = new Create_a_cat_s_diet;
            create_A_Cat_S_Diet.Show();
        }
    }
}
