using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Users\\Ivaylo\\Computer Science 2022 - 2023\\Final_Project\\Final_Project\\2023.mdf\";Integrated Security=True");
            
            if(this.imeil.Text.Contains('@') && this.parola1.Password==this.potv_parola1.Password)
            {
                //dobavi akaunt v databaza
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO Users(Username,Email,Password)values ('" + this.ime.Text + "','" + this.imeil.Text + "','" + this.parola1.Password + "') ";
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account created");
                    MainWindow mw = new MainWindow();
                    this.Hide();
                    mw.Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally

                {

                    sqlCon.Close();

                }

                

            }
            else
            {
                MessageBox.Show("Account couldn't be created. Check that your email contains the '@' symbol and that the text in the Password matches the one in the Confirm Password");
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
