﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFAcademyMVVMFinal.Views
{
    /// <summary>
    /// Lógica de interacción para StatisticsBySubjectsView.xaml
    /// </summary>
    public partial class StatisticsBySubjectsView : UserControl
    {
        public StatisticsBySubjectsView()
        {
            InitializeComponent();
        }

        private void ClearSelection(object sender, RoutedEventArgs e)
        {
            ComboBoxSubjects.SelectedIndex = -1;
            ComboBoxExams.SelectedIndex = -1;
        }
    }
}
