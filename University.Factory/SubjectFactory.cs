using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic.Exceptions;
using Models.Generics;
using Models.Professor;
using Models.Student;
using Models.Subject;

namespace Sist.Factory
{
    public class SubjectFactory
    {
        public static readonly SubjectFactory Instance = new SubjectFactory();

        private SubjectFactory()
        {
            
        }

        internal Subject CreateSubject()
        {
            
            var subject = new Subject();

            return subject;
        }

        internal Student CreateStudent(string regNumber, string name)
        {
            Contract.Requires<ArgumentInvalidLengthException>(name.Length >= 2 && name.Length <= 50, "Numele studentului trebuie sa contine intre 2 si 50 de caractere");
            Contract.Requires<ArgumentNullException>(name != null, "Numele studentului nu poate sa fie null");
            Contract.Requires<ArgumentNullException>(regNumber != null, "Numarul matricol al  studentului nu poate sa fie null");
            var student = new Student(
                                        new RegistrationNumber(regNumber),
                                        new PlainText(name));

            return student;
        }

        internal Professor CreateProfesor(string name)
        {
            Contract.Requires<ArgumentInvalidLengthException>(name.Length >= 2 && name.Length <= 50, "Numele profesorului trebuie sa contine intre 2 si 50 de caractere");
            Contract.Requires<ArgumentNullException>(name != null, "Numele profesorului nu poate sa fie null");

            var profesor = new Professor(
                new PlainText(name));

            return profesor;
        }


    }
}
