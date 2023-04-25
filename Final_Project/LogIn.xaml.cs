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
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //check whether username and password are in the database
            if (this.imetest.Text=="admin" && this.parolatest.Password == "1234") 
            {
                ChooseYourTeams cyt = new ChooseYourTeams();
                this.Hide();
                cyt.Show();

            }
            else
            {
                MessageBox.Show("Your username or password are not correct");
            }
        }
    }
}
