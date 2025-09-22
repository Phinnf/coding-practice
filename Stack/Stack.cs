namespace Coding_Practice.Stack
{
    public class Stack
    {
        public bool IsValid(string s)
        {
            while (s.Contains("()") || s.Contains("{}") || s.Contains("[]"))
            {
                s = s.Replace("()", "");
                s = s.Replace("{}", "");
                s = s.Replace("[]", "");
            }
            return s == "";
        }
    }
}
