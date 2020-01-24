using Academy.Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;
using WpfApp1.Lib.UI;

namespace AcademyFinal.App.WPF.ViewModels
{
    public class ExamsViewModel: ViewModelBase
    {
       
        public DateTime DateStamp
        {
            get
            {
                return _dateStamp;
            }
            set
            {
                _dateStamp = value;
                OnPropertyChanged();
            }
        }
        DateTime _dateStamp;

        public Subject Subject
        {
            get
            {
                return _subject;
            }
            set
            {
                _subject = value;
                OnPropertyChanged();
            }
        }
        Subject _subject;

        public Guid SubjectId
        {
            get
            {
                return _subjectId;
            }
            set
            {
                _subjectId = value;
                OnPropertyChanged();
            }
        }
        Guid _subjectId;

    }
}
