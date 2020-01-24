using Academy.Lib.Models;
using Academy.Lib.Repositories;
using AcademyFinal.App.WPF.UI;
using Common.Lib.Core;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Lib.UI;


namespace AcademyFinal.App.WPF.ViewModels
{
    public class StudentsViewModel : ViewModelBase
    {
        public string Dni
        {
            get
            {
                return _dni;
            }
            set
            {
                _dni = value;
                OnPropertyChanged();
            }
        }
        string _dni;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        string _name;

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }
        string _email;

        public string ChairNumber
        {
            get
            {
                return _chairNumber;
            }
            set
            {
                _chairNumber = value;
                OnPropertyChanged();
            }
        }
        string _chairNumber;

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
        string _password;

        public List<Student> Students
        {
            get
            {
                return _students;
            }
            set
            {
                _students = value;
                OnPropertyChanged();
            }
        }
        List<Student> _students;


        public StudentsViewModel()
        {
            

            AddStudentCommand = new RouteCommand(AddStudent);
            GetStudentsCommand = new RouteCommand(GetStudents);
        }

        public void AddStudent()
        {
            var student = new Student();

            student.Dni = this.Dni;
            student.Name = this.Name;
            student.Email = this.Email;
            student.ChairNumber = int.Parse(ChairNumber);
            //isConversionOk = int.TryParse(student.ChairNumber, out ChairNumber);

            var sr = student.Save();
            if (sr.IsSuccess)
                {
                MessageBox.Show("Registro completado"); //mensaje error
            }
            else MessageBox.Show ("No se ha podido completar el registro");   //allerrors get errors
            GetStudents();
        }

        public void GetStudents()
        {
            var repo = Entity.DepCon.Resolve<IStudentRepository>();
            Students = repo.QueryAll().ToList();
        }

        public void UpdateStudents()
        {
            var repo = Entity.DepCon.Resolve<IStudentRepository>();
            var currentStudent = repo.QueryAll().FirstOrDefault(x => x.Name.StartsWith("pocholo"));
            if (currentStudent != null)
            {
                var editStudent = currentStudent.Clone();
                editStudent.Name = this.Name;
                editStudent.Email = this.Email;
                editStudent.Dni = this.Dni;
                editStudent.ChairNumber = int.Parse(ChairNumber);
            }
        }

       
        public Student SelectedStudent
        {
            get
            {
                return _selectedStudent;
            }
            set
            {
                _selectedStudent = value;
                OnPropertyChanged();
            }
        }
        Student _selectedStudent;


        #region Commands
        public ICommand AddStudentCommand { get; set; }
        public ICommand GetStudentsCommand { get; set; }

        public ICommand UpdateStudentsCommand { get; set; }

        #endregion

    }
}
