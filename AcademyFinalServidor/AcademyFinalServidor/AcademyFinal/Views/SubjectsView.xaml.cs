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
    /// Interaction logic for SubjectsView.xaml
    /// </summary>
    public partial class SubjectsView : UserControl
    {
        SubjectsViewModel SubjectsVM = null;

        public SubjectsView()
        {
            InitializeComponent();
            SubjectsVM = new SubjectsViewModel();
            this.DataContext = SubjectsVM;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }


        private void Editar_Click(object sender, RoutedEventArgs e)
        {
            if (lbx_Subjects.SelectedItem != null && lbx_Subjects.SelectedIndex > -1)
            {
                //((StudentsViewModel)this.DataContext).SelectedStudent = (Student)lbx_Students.SelectedItem;
                SubjectsVM.SelectedSubject = (Subject)lbx_Subjects.SelectedItem;

            }

        }
    }
}
