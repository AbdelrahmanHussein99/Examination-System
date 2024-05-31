using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class MCQ : Question
    {
        #region Constructors
        public MCQ(string _Body, int _Mark, List<Answers>? _QuestionList, int _RightAnswer) : base(_Body, _Mark, _QuestionList, _RightAnswer)
        {
        }
        public MCQ() : base()
        {

        }
        #endregion

        #region Method 
        public override void CreateQuestion()
        {
            Console.WriteLine("MCQ Question \n");
            string AnswerBody, Body,line;
            int Marks, RightAnswer;
            List<Answers>? AnswersList = new List<Answers>();

          
            line = "Please Enter The Body Of Question:\n";
            Body = UserInput.EnterString(line, Validation.IsNullOrEmptyOrWhiteSpace);

           
            line = "Please Enter The Marks Of Question:\n";
            Marks = UserInput.EnterNumber(line, Validation.MoreThanZero);

            Console.WriteLine("The Choices Of Question:\n");

            for (int i = 1; i <= 3; i++)
            {
            
                line = $"Please Enter The Choice Number ({i}): ";
                AnswerBody = UserInput.EnterString(line, Validation.IsNullOrEmptyOrWhiteSpace);

                AnswersList.Add(new Answers(i, AnswerBody));
            }
          

            line = "\nPlease Specify The Right Choice Of Question:";
            RightAnswer = UserInput.EnterNumber(line, Validation.OneOrTwoOrThreeChoice);
            MCQ _MCQ = new MCQ(Body, Marks, AnswersList, RightAnswer);
            Console.Clear();

            QuestionList.AddQuestionToList(_MCQ);



        } 
        #endregion
    }
}
