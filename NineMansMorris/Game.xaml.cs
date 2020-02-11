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

namespace NineMansMorris
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {

        char Player = 'a';
        int turns = 0;

        public Game()
        {
            InitializeComponent();
            A_One.Background = Brushes.Transparent;
            A_Four.Background = Brushes.Transparent;
            A_Seven.Background = Brushes.Transparent;

            B_Two.Background = Brushes.Transparent;
            B_Four.Background = Brushes.Transparent;
            B_Six.Background = Brushes.Transparent;

            C_Three.Background = Brushes.Transparent;
            C_Four.Background = Brushes.Transparent;
            C_Five.Background = Brushes.Transparent;

            D_One.Background = Brushes.Transparent;
            D_Two.Background = Brushes.Transparent;
            D_Three.Background = Brushes.Transparent;
            D_Five.Background = Brushes.Transparent;
            D_Six.Background = Brushes.Transparent;
            D_Seven.Background = Brushes.Transparent;

            E_Three.Background = Brushes.Transparent;
            E_Four.Background = Brushes.Transparent;
            E_Five.Background = Brushes.Transparent;

            F_Two.Background = Brushes.Transparent;
            F_Four.Background = Brushes.Transparent;
            F_Six.Background = Brushes.Transparent;

            G_One.Background = Brushes.Transparent;
            G_Four.Background = Brushes.Transparent;
            G_Seven.Background = Brushes.Transparent;

            Player = 'W';
            
        }

        private void A_One_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            if(A1W.Visibility == Visibility.Hidden)
            {
                A1W.Visibility = Visibility.Visible;
                A1B.Visibility = Visibility.Hidden;
            }
            else if(A1B.Visibility == Visibility.Hidden)
            {
                A1B.Visibility = Visibility.Visible;
                A1W.Visibility = Visibility.Hidden;
            }
        }

        private void A_Four_Click(object sender, RoutedEventArgs e)
        {
            if (A4W.Visibility == Visibility.Hidden)
            {
                A4W.Visibility = Visibility.Visible;
                A4B.Visibility = Visibility.Hidden;
            }
            else if (A4B.Visibility == Visibility.Hidden)
            {
                A4B.Visibility = Visibility.Visible;
                A4W.Visibility = Visibility.Hidden;
            }
        }

        private void A_Seven_Click(object sender, RoutedEventArgs e)
        {
            if (A7W.Visibility == Visibility.Hidden)
            {
                A7W.Visibility = Visibility.Visible;
                A7B.Visibility = Visibility.Hidden;
            }
            else if (A7B.Visibility == Visibility.Hidden)
            {
                A7B.Visibility = Visibility.Visible;
                A7W.Visibility = Visibility.Hidden;
            }
        }

        private void B_Two_Click(object sender, RoutedEventArgs e)
        {
            if (B2W.Visibility == Visibility.Hidden)
            {
                B2W.Visibility = Visibility.Visible;
                B2B.Visibility = Visibility.Hidden;
            }
            else if (B2B.Visibility == Visibility.Hidden)
            {
                B2B.Visibility = Visibility.Visible;
                B2W.Visibility = Visibility.Hidden;
            }
        }

        private void B_Four_Click(object sender, RoutedEventArgs e)
        {
            if (B4W.Visibility == Visibility.Hidden)
            {
                B4W.Visibility = Visibility.Visible;
                B4B.Visibility = Visibility.Hidden;
            }
            else if (B4B.Visibility == Visibility.Hidden)
            {
                B4B.Visibility = Visibility.Visible;
                B4W.Visibility = Visibility.Hidden;
            }
        }

        private void B_Six_Click(object sender, RoutedEventArgs e)
        {
            if (B6W.Visibility == Visibility.Hidden)
            {
                B6W.Visibility = Visibility.Visible;
                B6B.Visibility = Visibility.Hidden;
            }
            else if (B6B.Visibility == Visibility.Hidden)
            {
                B6B.Visibility = Visibility.Visible;
                B6W.Visibility = Visibility.Hidden;
            }
        }

        private void C_Three_Click(object sender, RoutedEventArgs e)
        {
            if (C3W.Visibility == Visibility.Hidden)
            {
                C3W.Visibility = Visibility.Visible;
                C3B.Visibility = Visibility.Hidden;
            }
            else if (C3B.Visibility == Visibility.Hidden)
            {
                C3B.Visibility = Visibility.Visible;
                C3W.Visibility = Visibility.Hidden;
            }
        }

        private void C_Four_Click(object sender, RoutedEventArgs e)
        {
            if (C4W.Visibility == Visibility.Hidden)
            {
                C4W.Visibility = Visibility.Visible;
                C4B.Visibility = Visibility.Hidden;
            }
            else if (C4B.Visibility == Visibility.Hidden)
            {
                C4B.Visibility = Visibility.Visible;
                C4W.Visibility = Visibility.Hidden;
            }
        }

        private void C_Five_Click(object sender, RoutedEventArgs e)
        {
            if (C5W.Visibility == Visibility.Hidden)
            {
                C5W.Visibility = Visibility.Visible;
                C5B.Visibility = Visibility.Hidden;
            }
            else if (C5B.Visibility == Visibility.Hidden)
            {
                C5B.Visibility = Visibility.Visible;
                C5W.Visibility = Visibility.Hidden;
            }
        }

        private void D_One_Click(object sender, RoutedEventArgs e)
        {
            if (D1W.Visibility == Visibility.Hidden)
            {
                D1W.Visibility = Visibility.Visible;
                D1B.Visibility = Visibility.Hidden;
            }
            else if (D1B.Visibility == Visibility.Hidden)
            {
                D1B.Visibility = Visibility.Visible;
                D1W.Visibility = Visibility.Hidden;
            }
        }

        private void D_Two_Click(object sender, RoutedEventArgs e)
        {
            if (D2W.Visibility == Visibility.Hidden)
            {
                D2W.Visibility = Visibility.Visible;
                D2B.Visibility = Visibility.Hidden;
            }
            else if (D2B.Visibility == Visibility.Hidden)
            {
                D2B.Visibility = Visibility.Visible;
                D2W.Visibility = Visibility.Hidden;
            }
        }

        private void D_Three_Click(object sender, RoutedEventArgs e)
        {
            if (D3W.Visibility == Visibility.Hidden)
            {
                D3W.Visibility = Visibility.Visible;
                D3B.Visibility = Visibility.Hidden;
            }
            else if (D3B.Visibility == Visibility.Hidden)
            {
                D3B.Visibility = Visibility.Visible;
                D3W.Visibility = Visibility.Hidden;
            }
        }

        private void D_Five_Click(object sender, RoutedEventArgs e)
        {
            if (D5W.Visibility == Visibility.Hidden)
            {
                D5W.Visibility = Visibility.Visible;
                D5B.Visibility = Visibility.Hidden;
            }
            else if (D5B.Visibility == Visibility.Hidden)
            {
                D5B.Visibility = Visibility.Visible;
                D5W.Visibility = Visibility.Hidden;
            }
        }

        private void D_Six_Click(object sender, RoutedEventArgs e)
        {
            if (D6W.Visibility == Visibility.Hidden)
            {
                D6W.Visibility = Visibility.Visible;
                D6B.Visibility = Visibility.Hidden;
            }
            else if (D6B.Visibility == Visibility.Hidden)
            {
                D6B.Visibility = Visibility.Visible;
                D6W.Visibility = Visibility.Hidden;
            }
        }

        private void D_Seven_Click(object sender, RoutedEventArgs e)
        {
            if (D7W.Visibility == Visibility.Hidden)
            {
                D7W.Visibility = Visibility.Visible;
                D7B.Visibility = Visibility.Hidden;
            }
            else if (D7B.Visibility == Visibility.Hidden)
            {
                D7B.Visibility = Visibility.Visible;
                D7W.Visibility = Visibility.Hidden;
            }
        }

        private void E_Three_Click(object sender, RoutedEventArgs e)
        {
            if (E3W.Visibility == Visibility.Hidden)
            {
                E3W.Visibility = Visibility.Visible;
                E3B.Visibility = Visibility.Hidden;
            }
            else if (E3B.Visibility == Visibility.Hidden)
            {
                E3B.Visibility = Visibility.Visible;
                E3W.Visibility = Visibility.Hidden;
            }
        }

        private void E_Four_Click(object sender, RoutedEventArgs e)
        {
            if (E4W.Visibility == Visibility.Hidden)
            {
                E4W.Visibility = Visibility.Visible;
                E4B.Visibility = Visibility.Hidden;
            }
            else if (E4B.Visibility == Visibility.Hidden)
            {
                E4B.Visibility = Visibility.Visible;
                E4W.Visibility = Visibility.Hidden;
            }
        }

        private void E_Five_Click(object sender, RoutedEventArgs e)
        {
            if (E5W.Visibility == Visibility.Hidden)
            {
                E5W.Visibility = Visibility.Visible;
                E5B.Visibility = Visibility.Hidden;
            }
            else if (E5B.Visibility == Visibility.Hidden)
            {
                E5B.Visibility = Visibility.Visible;
                E5W.Visibility = Visibility.Hidden;
            }
        }

        private void F_Two_Click(object sender, RoutedEventArgs e)
        {
            if (F2W.Visibility == Visibility.Hidden)
            {
                F2W.Visibility = Visibility.Visible;
                F2B.Visibility = Visibility.Hidden;
            }
            else if (F2B.Visibility == Visibility.Hidden)
            {
                F2B.Visibility = Visibility.Visible;
                F2W.Visibility = Visibility.Hidden;
            }
        }

        private void F_Four_Click(object sender, RoutedEventArgs e)
        {
            if (F4W.Visibility == Visibility.Hidden)
            {
                F4W.Visibility = Visibility.Visible;
                F4B.Visibility = Visibility.Hidden;
            }
            else if (F4B.Visibility == Visibility.Hidden)
            {
                F4B.Visibility = Visibility.Visible;
                F4W.Visibility = Visibility.Hidden;
            }
        }

        private void F_Six_Click(object sender, RoutedEventArgs e)
        {
            if (F6W.Visibility == Visibility.Hidden)
            {
                F6W.Visibility = Visibility.Visible;
                F6B.Visibility = Visibility.Hidden;
            }
            else if (C3B.Visibility == Visibility.Hidden)
            {
                F6B.Visibility = Visibility.Visible;
                F6W.Visibility = Visibility.Hidden;
            }
        }

        private void G_One_Click(object sender, RoutedEventArgs e)
        {
            if (G1W.Visibility == Visibility.Hidden)
            {
                G1W.Visibility = Visibility.Visible;
                G1B.Visibility = Visibility.Hidden;
            }
            else if (G1B.Visibility == Visibility.Hidden)
            {
                G1B.Visibility = Visibility.Visible;
                G1W.Visibility = Visibility.Hidden;
            }
        }

        private void G_Four_Click(object sender, RoutedEventArgs e)
        {
            if (G4W.Visibility == Visibility.Hidden)
            {
                G4W.Visibility = Visibility.Visible;
                G4B.Visibility = Visibility.Hidden;
            }
            else if (G4B.Visibility == Visibility.Hidden)
            {
                G4B.Visibility = Visibility.Visible;
                G4W.Visibility = Visibility.Hidden;
            }
        }

        private void G_Seven_Click(object sender, RoutedEventArgs e)
        {
            if (G7W.Visibility == Visibility.Hidden)
            {
                G7W.Visibility = Visibility.Visible;
                G7B.Visibility = Visibility.Hidden;
            }
            else if (G7B.Visibility == Visibility.Hidden)
            {
                G7B.Visibility = Visibility.Visible;
                G7W.Visibility = Visibility.Hidden;
            }
        }
    }
}
