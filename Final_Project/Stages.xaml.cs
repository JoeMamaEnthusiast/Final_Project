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
    /// Interaction logic for Stages.xaml
    /// </summary>
    public partial class Stages : Window
    {
        public Stages()
        {
            InitializeComponent();
        }

        public string[] arrOtbori = new string[8];
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GroupStage gs = new GroupStage();
            this.Hide();
            gs.Show();
            
            

            
            
            gs.otbor1.Text = arrOtbori[0];
            gs.otbor2.Text = arrOtbori[1];
            gs.otbor3.Text = arrOtbori[2];
            gs.otbor4.Text = arrOtbori[3];
            gs.otbor5.Text = arrOtbori[4];
            gs.otbor6.Text = arrOtbori[5];
            gs.otbor7.Text = arrOtbori[6];
            gs.otbor8.Text = arrOtbori[7];




        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {

        }

       
    }
}
