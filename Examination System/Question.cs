using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal abstract class Question
    {
        #region Properties
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public List<Answers>? AnswersList { get; set; }

        public int RightAnswer { get; set; }
        public int UserAnswer { get; set; }


        #endregion
        #region Constructors
        public Question()
        {

        }
        // Constructor for MCQ Question
        public Question(string _Body, int _Mark, List<Answers>? _AnswersList, int _RightAnswer)
        {
            Header = "MCQ Question";
            Body = _Body;
            Mark = _Mark;
            AnswersList = _AnswersList;
            RightAnswer = _RightAnswer;

        }
        // Constructor for True | False Question
        public Question(string _Body, int _Mark, int _RightAnswer)
        {
            Header = "True | False Question";
            Body = _Body;
            Mark = _Mark;
            AnswersList = new List<Answers>() {
                new Answers(1,"True") ,
                new Answers(2,"False"),
            };
            RightAnswer = _RightAnswer;

        }
        #endregion

        #region Methods
        public abstract void CreateQuestion();

        public override string ToString()
        {
            return $"{Header}\t\tMarK({Mark})\n\n{Body}\n";
        } 
        #endregion

    }



}
