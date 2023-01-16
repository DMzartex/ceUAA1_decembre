﻿using System;
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

namespace CeUAA14Partie2_dec22_Michaux
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            setupInterface();
        }

        public void setupInterface()
        {
            this.Width = 800;
            this.Height = 720;
            this.FontSize = 30;

            Grid gridPlateau = new Grid();
            RowDefinition[] rowdef = new RowDefinition[10];
            ColumnDefinition[] colDef = new ColumnDefinition[10];

            for(int i = 0; i < 10; i++)
            {
                rowdef[i] = new RowDefinition();
                gridPlateau.RowDefinitions.Add(rowdef[i]);
            }

            for(int y = 0; y <10; y++)
            {
                colDef[y] = new ColumnDefinition();
                gridPlateau.ColumnDefinitions.Add(colDef[y]);
            }

            Grid.SetColumn(gridPlateau, 0);
            Grid.SetRow(gridPlateau, 1);
            grdMain.Children.Add(gridPlateau);


            Button[,] btnJeux = new Button[10, 10];

            for(int x = 0; x < 10; x++)
            {
                for (int j = 0; j < 10; j++)
                {
                    btnJeux[x,j] = new Button();
                    if(x % 2 == 0)
                    {
                        int numberCase = (10 * x) + j + 1;
                        btnJeux[x, j].Content = Convert.ToString(numberCase);

                    }
                    else
                    {
                        int numberCase = (10 * x) + 10 - j;
                        btnJeux[x, j].Content = Convert.ToString(numberCase);
                    }

                    if (int.Parse((string)btnJeux[x,j].Content) % 2 == 0)
                    {
                        btnJeux[x, j].Background = Brushes.Blue;
                    }
                    else
                    {
                        btnJeux[x, j].Background = Brushes.Red;
                    }

                    btnJeux[x,j].HorizontalAlignment = HorizontalAlignment.Center;
                    btnJeux[x,j].VerticalAlignment = VerticalAlignment.Center;
                    btnJeux[x, j].Width = 60;
                    btnJeux[x, j].Height = 60;
                    Grid.SetRow(btnJeux[x, j], x);
                    Grid.SetColumn(btnJeux[x, j], j);

                    gridPlateau.Children.Add(btnJeux[x, j]);

                }
            }


        }

        private void ClickJouer(object sender, RoutedEventArgs e)
        {
            Random random = new Random(); ;
            int de = random.Next(1,7);
            int totalJoueur = 0;
            totalJoueur = totalJoueur + de;
            int[] positionPionJoueur = new int[2];
            int reste = totalJoueur - 10 * (positionPionJoueur[0] + 1);

            if(reste < 0)
            {
                reste = reste + 10;

            }
            else
            {
                positionPionJoueur[0] = positionPionJoueur[0] + 1;
            }

            if (positionPionJoueur[0] % 2 != 0)
            {
                positionPionJoueur[1] = 9 - reste;
            }
            else
            {
                positionPionJoueur[1] = reste;
            }

            if (positionPionJoueur[0] <= 9)
            {
                
            }
            else
            {
                
            }
        }
    }
}
