﻿using Academy.Lib.Models;
using Common.Lib.Core.Context;
using Common.Lib.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using WPFAcademyMVVMFinal.Lib.UI;

namespace WPFAcademyMVVMFinal.ViewModels
{
    public class StudentsViewModel : ViewModelBase
    {
        
        public StudentsViewModel()
        {
            SaveStudentCommand = new RouteCommand(SaveStudent);
            GetStudentsCommand = new RouteCommand(GetStudents);
            DelStudentCommand = new RouteCommand(DelStudent);
            EditStudentCommand = new RouteCommand(EditStudent);
        }

        #region Commands
        public ICommand SaveStudentCommand { get; set; }
        public ICommand GetStudentsCommand { get; set; }

        public ICommand DelStudentCommand { get; set; } 
        public ICommand EditStudentCommand { get; set; }
        #endregion



        private string _dniVM;

        public string DniVM
        {
            get { return _dniVM; }
            set
            {
                _dniVM = value;
                OnPropertyChanged();
            }
        }

        private string _nameVM;

        public string NameVM
        {
            get { return _nameVM; }
            set
            {
                _nameVM = value;
                OnPropertyChanged();
            }
        }

        private string _chairTextVM;

        public string ChairTextVM
        {
            get { return _chairTextVM; }
            set
            {
                _chairTextVM = value;
                OnPropertyChanged();
            }
        }


        private int _chairNumberVM;

        public int ChairNumberVM
        {
            get { return _chairNumberVM; }
            set
            {
                _chairNumberVM = value;
                OnPropertyChanged();
            }
        }

        private string _emailVM;

        public string EmailVM
        {
            get { return _emailVM; }
            set
            {
                _emailVM = value;
                OnPropertyChanged();
            }
        }


        private Student _currentStudent;
        public Student CurrentStudent  
        {
            get { return _currentStudent; }
            set
            {
                _currentStudent = value;
                OnPropertyChanged();
            }
        }


        List<ErrorMessage> _errorsList;
        public List<ErrorMessage> ErrorsList
        {
            get
            {
                return _errorsList;
            }
            set
            {
                _errorsList = value;
                OnPropertyChanged();
            }
        }


        List<Student> _studentsListNou;
        public List<Student> StudentsListNou
        {
            get
            {
                return _studentsListNou;
            }
            set
            {
                _studentsListNou = value;
                OnPropertyChanged();
            }
        }

        
        public void ChairStringToInt()
        {
            var chairVR = Student.ValidateChairNumber(ChairTextVM);
            if (!chairVR.IsSuccess)
            {
                ErrorsList = chairVR.Errors.Select(x => new ErrorMessage() { Message = x }).ToList();
                CurrentStudent = null;
                DniVM = "";
                NameVM = "";
                ChairTextVM = "";
                EmailVM = "";
            }

            else
            {
                ChairNumberVM = chairVR.ValidatedResult;
            }

        }



        bool isEdit = false;

        public void SaveStudent()
        {

            ChairStringToInt();

            if (ChairNumberVM != 0)
            {
                Student student = new Student()
                {
                    Dni = DniVM,
                    Name = NameVM,
                    ChairNumber = ChairNumberVM,
                    Email = EmailVM

                };

                if (isEdit == false)
                    CurrentStudent = null;

                if (CurrentStudent != null)
                    student.Id = CurrentStudent.Id;

                student.Save();


                ErrorsList = student.CurrentValidation.Errors.Select(x => new ErrorMessage() { Message = x }).ToList();
                GetStudents();
                CurrentStudent = null;
                DniVM = "";
                NameVM = "";
                ChairTextVM = "";
                EmailVM = "";

            }

            isEdit = false;
        }

        public void GetStudents()
        {

            var student = new Student();
            var repo = Student.DepCon.Resolve<IRepository<Student>>();
            StudentsListNou = repo.QueryAll().ToList();

        }


        public void DelStudent()    
        {

            Student student = new Student();

            if (CurrentStudent == null)
            {
                student.Delete();  
                ErrorsList = student.CurrentValidation.Errors.Select(x => new ErrorMessage() { Message = x }).ToList();

            }

            else
            {
                student = CurrentStudent;

                student.Delete();

                ErrorsList = new List<ErrorMessage>();
                ErrorsList = student.CurrentValidation.Errors.Select(x => new ErrorMessage() { Message = x }).ToList();

                GetStudents();

                DniVM = "";
                NameVM = "";
                ChairNumberVM = 0;
                EmailVM = "";

            }
        }



        public void EditStudent()    
        {
            var student = new Student();

            if (CurrentStudent == null)
            {
                student.Save();
                ErrorsList = student.CurrentValidation.Errors.Select(x => new ErrorMessage() { Message = x }).ToList();
            }

            else
            {
                ErrorsList = new List<ErrorMessage>();
                student = CurrentStudent;

                DniVM = CurrentStudent.Dni;
                NameVM = CurrentStudent.Name;
                ChairNumberVM = CurrentStudent.ChairNumber;
                EmailVM = CurrentStudent.Email;

                isEdit = true;

            }
        }


    }

}
