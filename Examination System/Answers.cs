using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Answers
    {
        #region Properties
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        #endregion

        #region Constructors
        public Answers()
        {

        }
        public Answers(int _AnswerId, string _AnswerText)
        {
            AnswerId = _AnswerId;
            AnswerText = _AnswerText;
        } 
        #endregion

        public override string ToString()
        {
            return $"{AnswerId}. {AnswerText}";
        }
    }
}
