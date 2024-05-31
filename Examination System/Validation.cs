using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal static class Validation

    {

        #region Methods
        public static bool IsNullOrEmptyOrWhiteSpace(string line)
        {
            return (string.IsNullOrWhiteSpace(line) || line.Length == 0);

        }

        public static bool OneOrTwoChoice(int choice)
        {
            return (choice == 1 || choice == 2);

        }
        public static bool OneOrTwoOrThreeChoice(int choice)
        {
            return (choice == 1 || choice == 2 || choice == 3);

        }
        public static bool MoreThanZero(int value)
        {
            return value > 0;

        } 

        #endregion

    }
}
