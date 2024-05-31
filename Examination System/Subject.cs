using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Subject
    {

        #region Properties
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam? ExamOfSubject { get; set; }

        #endregion

        #region Constructors
        public Subject(int _SubjectId, string _SubjectName)
        {
            SubjectId = _SubjectId;
            SubjectName = _SubjectName;
            ExamOfSubject = null;
        }
        #endregion

        #region Method Create Exam
        public void CreateExam()
        {
            int choice, time, number;
            bool vaild;

            
            string line = "Please Enter The Type Of Exam You Want To Create( 1 for Practical Exam and 2 for Final Exam):";
            choice =UserInput.EnterNumber(line,Validation.OneOrTwoChoice);

            line = "Please Enter The Time Of Exam in Minutes:";
            time = UserInput.EnterNumber(line, Validation.MoreThanZero);

          
            line = "Please Enter The Number Of Questions You Want To Create:";
            number = UserInput.EnterNumber(line, Validation.MoreThanZero);

            if (choice == 1)
            {
                ExamOfSubject = new PracticalExam(time, number, this);
            }
            else if (choice == 2)
            {
                ExamOfSubject = new FinalExam(time, number, this);
            }
            Console.Clear();
            ExamOfSubject.CreateQuestionInExam();

        } 
        #endregion
    }
}
