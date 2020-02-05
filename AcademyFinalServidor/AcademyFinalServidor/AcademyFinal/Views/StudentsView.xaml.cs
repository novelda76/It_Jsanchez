using Academy.Lib.Models;
using AcademyFinal.App.WPF.ViewModels;
using System;
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

namespace AcademyFinal.App.WPF.Views
{
    /// <summary>
    /// Interaction logic for StudentsView.xaml
    /// </summary>
    public partial class StudentsView : UserControl
    {
        StudentsViewModel StudentsVM = null;
        public StudentsView()
        {
            InitializeComponent();
            StudentsVM = new StudentsViewModel();
            this.DataContext = StudentsVM;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }

      
        private void Editar_Click(object sender, RoutedEventArgs e)
        {
            if (lbx_Students.SelectedItem != null && lbx_Students.SelectedIndex > -1)
            {
                //((StudentsViewModel)this.DataContext).SelectedStudent = (Student)lbx_Students.SelectedItem;
                StudentsVM.SelectedStudent = (Student)lbx_Students.SelectedItem;

            }

        }
    }
}
