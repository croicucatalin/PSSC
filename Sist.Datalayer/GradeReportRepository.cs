using Sist.Datalayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sist.Datalayer
{
    public class GradeReportRepository<T> where T : class, IDataAccessObject, new()
    {

        public virtual async Task<T> CreateGradeReport()
        {
            return null;
        }
        public virtual async Task<T> GetGradeReport()
        {
            return null;
        }
        public virtual async Task<T> EditGradeReport()
        {
            return null;
        }
        public virtual async Task<T> RemoveGradeReport()
        {
            return null;
        }
    }
}
