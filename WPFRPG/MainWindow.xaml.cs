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

namespace WPFRPG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameSession gameSession;

        public MainWindow()
        {
            InitializeComponent();

            gameSession = new GameSession();

            DataContext = gameSession;
        }

        public void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            gameSession.CurrentPlayer.Experience += 10;
        }
    }
}
