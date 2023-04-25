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

namespace Final_Project
{
    /// <summary>
    /// Interaction logic for ChooseYourTeams.xaml
    /// </summary>
    public partial class ChooseYourTeams : Window
    {
        public ChooseYourTeams()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InputTeams8 it8 = new InputTeams8();
            this.Hide();
            it8.Show();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {

        }
    }
}
