using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Student;
using Models.Subject;

namespace Sist.Factory
{
    public class GradeReportFactory
    {
        public static readonly GradeReportFactory Instance = new GradeReportFactory();

        private GradeReportFactory()
        { }

        public NotesReport CreateGradeReport()
        {
            var gradeReport = new NotesReport();

            return gradeReport;
        }
    }
}
