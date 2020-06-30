using System.Collections;
using System.Text;

namespace LeetCode._1._1_50
{
    /// <summary>
    /// 20.有效括号
    /// </summary>
    public class ValidParenthesis_20
    {

        private string _parenthesis;

        private Hashtable hashtable = new Hashtable() {
            {"{","}"},
            {"(",")"},
            {"[","]"}
        };

        public ValidParenthesis_20()
        {
            _parenthesis = "{()[}";
        }


        public bool Run()
        {

            var test = _parenthesis.ToCharArray();

            for (int i = 0; i < test.Length; i++)
            {
                
            }

            return true;
        }
    }
}
