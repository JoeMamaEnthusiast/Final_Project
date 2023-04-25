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
    /// Interaction logic for GroupStage.xaml
    /// </summary>
    public partial class GroupStage : Window
    {
        public GroupStage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Schedule sch = new Schedule();
            this.Hide();
            sch.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Stages st = new Stages();
            this.Hide();
            st.Show();
        }
    }
}
