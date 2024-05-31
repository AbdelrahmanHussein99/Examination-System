using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class TFQuestion : Question
    {
        #region Constructor
        public TFQuestion(string _Body, int _Mark, int _RightAnswer) : base(_Body, _Mark, _RightAnswer)
        {

        }
        public TFQuestion() : base()
        {

        }
        #endregion


        #region Method
        public override void CreateQuestion()
        {
            Console.WriteLine("True | False Question \n");
            string Body, line;
            int Marks, RightAnswer;


            line = "Please Enter The Body Of Question:\n";
            Body = UserInput.EnterString(line, Validation.IsNullOrEmptyOrWhiteSpace);


            line = "Please Enter The Marks Of Question:\n";
            Marks = UserInput.EnterNumber(line, Validation.MoreThanZero);

            line = "Please Enter The Right Answer Of Question ( 1 for True  and 2 for False ):";
            RightAnswer = UserInput.EnterNumber(line, Validation.OneOrTwoChoice);

            TFQuestion tFQuestion = new TFQuestion(Body, Marks, RightAnswer);
            Console.Clear();
            QuestionList.AddQuestionToList(tFQuestion);

        } 
        #endregion


    }
}
