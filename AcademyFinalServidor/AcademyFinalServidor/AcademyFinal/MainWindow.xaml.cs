﻿using AcademyFinal.App.WPF.ViewModels;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AcademyFinal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        public void TestLogin_Ok()
        {
            var loginVM = new LoginViewModel();
            loginVM.Email = "lolo@lolo.com";
            loginVM.Password = "1234";

            loginVM.Login();

            //if (loginVM.LoginResult == "El login está bien, bienvenid@!") 

        }
    }
}