using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Academy.Lib.DAL;
using Academy.Lib.DAL.Repositories;
using Academy.Lib.Models;
using Academy.Lib.Repositories;
using AcademyFinal.App.WPF.DbContextFactory;
using AcademyFinal.App.WPF.UI;
using Common.Lib.Core;
using Common.Lib.Core.Context;
using Common.Lib.DAL.EFCore;
using Common.Lib.Infrastructure;
using Microsoft.EntityFrameworkCore;
using WpfApp1.Lib.UI;

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

        public List<Subject> Subjects
        {
            get
            {
                return _subjects;
            }
            set
            {
                _subjects = value;
                OnPropertyChanged();
            }
        }
        List<Subject> _subjects;


        public SubjectsViewModel()
        {


            AddSubjectCommand = new RouteCommand(AddSubject);
            GetSubjectsCommand = new RouteCommand(GetSubjects);
        }

        public void AddSubject()
        {
            var subject = new Subject();

            
            subject.Name = this.Name;
            subject.Teacher = this.Teacher;          

            subject.Save();
            GetSubjects();
        }

        public void GetSubjects()
        {
            //var repo = Entity.DepCon.Resolve<ISubjectsRepository>();
            //Subjects = repo.QueryAll().ToList();

            var subject = new Subject();
            var repo = Subject.DepCon.Resolve<IRepository<Subject>>();
            Subjects = repo.QueryAll().ToList();
        }

        #region Commands
        public ICommand AddSubjectCommand { get; set; }
        public ICommand GetSubjectsCommand { get; set; }

        #endregion
    }
}
