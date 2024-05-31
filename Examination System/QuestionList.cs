using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class QuestionList
    {
        #region Properties
        public static List<Question> Question_List;
        #endregion

        #region static Constructor
        static QuestionList()
        {
            Question_List = new List<Question>();
        }
        #endregion


        #region Methods

        public static void AddQuestionToList(Question question)
        {
            if (question is not null)
            {
                Question_List.Add(question);
                Console.WriteLine("Question Added Successfully...");
                Thread.Sleep(500);
                Console.Clear();

            }
        }

        #endregion

    }
}
