using Common.Lib.Core;
using System;


namespace Academy.Lib.Models
{
    public class Exam: Entity
    {

        public DateTime DateStamp { get; set; }
      
        public Subject Subject { get; set; }
        
        public Guid SubjectId { get; set; }

        public Exam()
        {

        }

    }
}
