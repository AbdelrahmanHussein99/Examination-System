using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class FinalExam :Exam
    {
        #region Constructor
        public FinalExam(int _TimeOfExam, int _NumberOfQuestions, Subject _Subject) : base(_TimeOfExam, _NumberOfQuestions, _Subject)
        {
           
        }
        #endregion


        #region Methods


        #region Create Questions In Exam with specific type of Question
        public override void CreateQuestionInExam()
        {
            
            int choice;
            string line;
            for (int i = 1; i <= NumberOfQuestions; i++)
            {
                line = $"Please Choose The Type Of Question Number({i})  ( 1 for True Or False || 2 for MCQ) : ";
                choice = UserInput.EnterNumber(line, Validation.OneOrTwoChoice);
                if (choice == 1)
                {
                    TFQuestion _TF = new TFQuestion();
                    _TF.CreateQuestion();
                }
                else if (choice == 2)
                {
                    MCQ _MCQ = new MCQ();
                    _MCQ.CreateQuestion();
                }
            }


        }
        #endregion

        #region Show Exam
        public override void ShowExam()
        {
            if (QuestionList.Question_List is not null)
            {
                int FullMarks = 0, UserMarks = 0;
                ExamProcesses.ShowAndCorrectionExam(out UserMarks, out FullMarks);


                Console.WriteLine($"Your Answers:");

                for (int i = 0; i < QuestionList.Question_List.Count; i++)
                {
                    ExamProcesses.PrintResult(QuestionList.Question_List[i], QuestionList.Question_List[i].UserAnswer, i);
                }

                Console.WriteLine($"Your Exam Grade is {FullMarks} From {UserMarks}");
            }

        }

        #endregion
        #endregion


    }
}
