﻿using Academy.Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Lib.Repositories
{
    public interface IExamsRepository
    {
        Exam GetExamByName(string name);
    }
}
