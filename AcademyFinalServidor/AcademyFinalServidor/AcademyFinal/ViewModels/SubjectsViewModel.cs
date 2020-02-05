using Academy.Lib.DAL.Repositories;
using Academy.Lib.Models;
using Academy.Lib.Repositories;
using AcademyFinal.App.WPF.UI;
using Common.Lib.Core;
using Common.Lib.Core.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace AcademyFinal.App.WPF.ViewModels
{
    public class SubjectsViewModel : ViewModelBase
    {
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

        public string Teacher
        {
            get
            {
                return _teacher;
            }
            set
            {
                _teacher = value;
                OnPropertyChanged();
            }
        }
        string _teacher;
     
        
        public List<Subject> SubjectList
        {
            get
            {
                return _subjectList;
            }
            set
            {
                _subjectList = value;
                OnPropertyChanged();
            }
        }
        List<Subject> _subjectList;


        public Subject _SelectedSubject;
        public Subject SelectedSubject
        {
            get { return _SelectedSubject; }
            set
            {
                _SelectedSubject = value;
                Name = _SelectedSubject.Name;
                Teacher = _SelectedSubject.Teacher;

                OnPropertyChanged("SelectedSubject");
            }
        }

        public SubjectsViewModel()
        {
            AddSubjectCommand = new RouteCommand(AddSubject);
            UpdateSubjectCommand = new RouteCommand(UpdateSubject);
            GetSubjectsCommand = new RouteCommand(GetSubject);

        }

        public void AddSubject()
        {
            var subject = new Subject();

            subject.Name = this.Name;
            subject.Teacher = this.Teacher;

            var sr = subject.Save();

            if (sr.IsSuccess)
            {
                MessageBox.Show($"Asignatura CREADO correctamente");
            }
            else
            {
                MessageBox.Show($"uno o más errores han ocurrido y la asignatura no se guardado correctamente: {sr.AllErrors}");
            }

            GetSubject();
         
        }

        public void GetSubject()
        {
            var repo = Entity.DepCon.Resolve<ISubjectsRepository>();
            SubjectList = repo.QueryAll().ToList(); 
        }

        public void UpdateSubject()
        {
            if (SelectedSubject != null)
            {
                var editSubject = SelectedSubject.Clone();

                editSubject.Name = this.Name;
                editSubject.Teacher = this.Teacher;

                var sr = editSubject.Save();

                if (sr.IsSuccess)
                {
                    MessageBox.Show($"alumno MODIFICADO correctamente");
                }
                else
                {
                    MessageBox.Show($"uno o más errores han ocurrido y el almuno no se guardado correctamente: {sr.AllErrors}");
                }

                GetSubject();
            }
        }


        #region Commands
        public ICommand AddSubjectCommand { get; set; }
        public ICommand UpdateSubjectCommand { get; set; }
        public ICommand GetSubjectsCommand { get; set; }

        #endregion

    }
}
