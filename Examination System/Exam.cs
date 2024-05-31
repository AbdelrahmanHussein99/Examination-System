using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal abstract class Exam
    {
        #region Properties
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public Subject? Subject { get; set; }

        #endregion
        #region Constructor

        public Exam(int _TimeOfExam, int _NumberOfQuestions, Subject _Subject)
        {
            TimeOfExam = _TimeOfExam;
            NumberOfQuestions = _NumberOfQuestions;
            Subject = _Subject;
        }
        #endregion


        #region Methods
        public abstract void CreateQuestionInExam();

        public abstract void ShowExam();

        #endregion


    }
}
