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
    /// Interaction logic for InputTeams8.xaml
    /// </summary>
    public partial class InputTeams8 : Window
    {
        public InputTeams8()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        public string[] arr = new string[8];
        
        private int count = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (count < 8)
            {
                
                arr[count] = this.otbori.Text;
                
                MessageBox.Show($"You have added the team {arr[count]} ");
                count++;
                this.otbori.Clear();
            }
            else
            {
                MessageBox.Show("You have already added 8 teams");
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}, {arr[5]}, {arr[6]}, {arr[7]}");
        }
        string tournamentName = "";
        
        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            tournamentName = this.ime.Text;
            


            if (count == 8 && tournamentName != string.Empty)
            {
                
                

                Stages st = new Stages();
                this.Hide();
                st.Show();
                st.turnirime.Text = tournamentName;


                Random random = new Random();
                arr = arr.OrderBy(x => random.Next()).ToArray();

                for (int i = 0; i < arr.Length; i++)
                {
                    st.arrOtbori[i] = arr[i];
                }

                MessageBox.Show("You have created the tournament!");


            }
            else
            {
                MessageBox.Show($"Tournament couldn't be created. Check that you have input all your teams and there is a tournament name. count = {count}, tournamentname = {tournamentName}");
            }
            

        }

        
    }
}
