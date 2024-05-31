using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal static class ExamProcesses
    {
        #region Methods
        public static void ShowQuestion(Question question)
        {
            if (question is not null)
            {
                Console.WriteLine(question);

                if (question.AnswersList is not null)
                {
                    foreach (Answers Answer in question.AnswersList)
                    {
                        Console.Write($"{Answer}\t\t");
                    }
                    Console.WriteLine("\n-------------------------------------");

                }
            }

        }

        public static int TakeAnswer(Question question)
        {
            int UserAnswer = -1;
            if (question is not null)
            {
                if (question.AnswersList is not null)
                {
                    bool vaild;
                    do
                    {
                        Console.Write("Please Enter the answer number from the choices:");
                        vaild = int.TryParse(Console.ReadLine(), out UserAnswer);
                    } while (!(vaild && (UserAnswer >= 1 && UserAnswer <= question.AnswersList?.Count)));

                    question.UserAnswer = UserAnswer;

                }

            }

            return UserAnswer;
        }
        //  Print Result after finish the Exam
        public static void PrintResult(Question question, int index, int num)
        {
            Console.WriteLine($"Q{num + 1})\t {question.Body}: {question.AnswersList?[index - 1].AnswerText}");

        }

        // Show exam and calc full marks calc user makes for the correct answer to every question

        public static void ShowAndCorrectionExam(out int UserMarks, out int FullMarks)
        {
            FullMarks = UserMarks = 0;
            int userAnswer = -1;

            if (QuestionList.Question_List is not null)
            {
                foreach (Question question in QuestionList.Question_List)
                {
                    FullMarks += question.Mark;
                    ShowQuestion(question);

                    userAnswer = TakeAnswer(question);

                    if (userAnswer.CompareTo(question.RightAnswer) == 0)
                    {
                        UserMarks += question.Mark;
                    }

                    //OR


                    //if (question.AnswersList[userAnswer-1].Equals(question.AnswersList[question.RightAnswer - 1]))
                    //{
                    //    UserMarks += question.Mark;
                    //}
                    Console.WriteLine("\n========================================\n");
                }
            }

            Console.Clear();
        } 
        #endregion
    }
}
