using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sist.Datalayer.Interfaces;

namespace Sist.Datalayer
{
    public class SubjectRepository<T> where T : class, IDataAccessObject, new()
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
