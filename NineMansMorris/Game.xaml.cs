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

        private void On_Click(object sender, RoutedEventArgs e)
        {

            Button btn = sender as Button;


           if (Player == 'W')
           {
                if (btn.Background == Brushes.Black || btn.Background == Brushes.Transparent)
                {


                    btn.Background = Brushes.Transparent;
                    Player = 'B';
                    turns++;
                }
           }
           else if (Player == 'B')
           {
                if (btn.Background == Brushes.White || btn.Background == Brushes.Transparent)
                {
                    btn.Background = Brushes.Black;
                    Player = 'W';
                    turns++;
                }
           }


        }
    }
}
