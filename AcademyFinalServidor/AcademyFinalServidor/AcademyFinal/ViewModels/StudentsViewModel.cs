using Academy.Lib.DAL.Repositories;
using Academy.Lib.Models;
using Academy.Lib.Repositories;
using AcademyFinal.App.WPF.UI;
using Common.Lib.Core;
using Common.Lib.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace AcademyFinal.App.WPF.ViewModels
{
    public class StudentsViewModel : ViewModelBase
    {
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
     
        
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("No puede estar vacio");
                _name = value;
                OnPropertyChanged();
            }
        }
        string _name;


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

        private Guid _id = default;

        public Guid Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }




        public List<Student> StudentsList
        {
            get
            {
                return _studentsList;
            }
            set
            {
                _studentsList = value;
                OnPropertyChanged();
            }
        }
        List<Student> _studentsList;


        public Student _SelectedStudent;
        public Student SelectedStudent
        {
            get { return _SelectedStudent; }
            set
            {
                _SelectedStudent = value;
                Name = _SelectedStudent.Name;
                Dni = _SelectedStudent.Dni;
                ChairNumber = _SelectedStudent.ChairNumber.ToString();

                OnPropertyChanged("SelectedStudent");
            }
        }

        public StudentsViewModel()
        {
            AddStudentCommand = new RouteCommand(AddStudent);
            UpdateStudentCommand = new RouteCommand(UpdateStudent);
            GetStudentsCommand = new RouteCommand(GetStudents);

        }

        public void AddStudent()
        {

            ValidationResult<string> vrName = Student.ValidateName(this.Name);
            ValidationResult<string> vrDni = Student.ValidateDni(this.Dni);
            ValidationResult<int> vrChair = Student.ValidateChairNumber(this.ChairNumber, Id);

            if (vrDni.IsSuccess && vrName.IsSuccess && vrChair.IsSuccess)
            {
                
                var student = new Student();

                student.Dni = Dni;
                student.Name = this.Name;
                student.ChairNumber = int.Parse(this.ChairNumber);

                var sr = student.Save();

                if (sr.IsSuccess)
                {
                    MessageBox.Show($"alumno CREADO correctamente");
                }
                else
                {
                    MessageBox.Show($"uno o más errores han ocurrido y el almuno no se guardado correctamente: {sr.AllErrors}");
                }

                GetStudents();

            }
        }

        public void GetStudents()
        {
            var repo = Entity.DepCon.Resolve<IStudentRepository>();
            StudentsList = repo.QueryAll().ToList(); 
        }

        public void UpdateStudent()
        {
            if (SelectedStudent != null)
            {
                var editStudent = SelectedStudent.Clone();
            
                editStudent.Email = this.Email;
                editStudent.Name = this.Name;
                editStudent.Dni = this.Dni;
                editStudent.ChairNumber = int.Parse(this.ChairNumber);           

                var sr = editStudent.Save();

                if (sr.IsSuccess)
                {
                    MessageBox.Show($"alumno MODIFICADO correctamente");
                }
                else
                {
                    MessageBox.Show($"uno o más errores han ocurrido y el almuno no se guardado correctamente: {sr.AllErrors}");
                }

                GetStudents();
            }
        }


        #region Commands
        public ICommand AddStudentCommand { get; set; }
        public ICommand UpdateStudentCommand { get; set; }

        public ICommand GetStudentsCommand { get; set; }

        #endregion

    }
}
