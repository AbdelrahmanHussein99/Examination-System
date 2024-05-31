using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal static class UserInput
    {
        #region method
        public static int EnterNumber(string line, Predicate<int> referene)
        {
            int value;
            bool Vaild;
            do
            {
                Console.Write(line);
                Vaild = int.TryParse(Console.ReadLine(), out value);
            } while (!(Vaild && referene(value)));

            return value;
        }


        public static string EnterString(string line, Predicate<string> referene)
        {
            string value;

            do
            {
                Console.Write(line);
                value = Console.ReadLine();
            } while (Validation.IsNullOrEmptyOrWhiteSpace(value));

            return value;
        } 
        #endregion
    }
}
