using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class PracticalExam : Exam
    {

        #region Constructor

        public PracticalExam(int _TimeOfExam, int _NumberOfQuestions, Subject _Subject) : base(_TimeOfExam, _NumberOfQuestions, _Subject)
        {

        }
        #endregion

        #region Methods

        #region Create Questions In Exam with MCQ Question
        public override void CreateQuestionInExam()
        {
            for (int i = 1; i <= NumberOfQuestions; i++)
            {
                Console.WriteLine($"Please Enter The Question Number({i})");
                MCQ _MCQ = new MCQ();
                _MCQ.CreateQuestion();
            }


        }
        #endregion

        #region Show Exam, Sum Marks, print result
        public override void ShowExam()
        {
            int FullMarks = 0, UserMarks = 0;
            ExamProcesses.ShowAndCorrectionExam(out UserMarks, out FullMarks);

            Console.WriteLine("Your Answers:");

            for (int i = 0; i < QuestionList.Question_List.Count; i++)
            {
                ExamProcesses.PrintResult(QuestionList.Question_List[i], QuestionList.Question_List[i].RightAnswer, i);
            }

            Console.WriteLine($"Your Exam Grade is {FullMarks} From {UserMarks}");

        }

      
        #endregion
        #endregion
    }
}
