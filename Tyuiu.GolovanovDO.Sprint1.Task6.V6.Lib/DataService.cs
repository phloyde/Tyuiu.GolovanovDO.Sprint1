using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GolovanovDO.Sprint1.Task6.V6.Lib
{
    public class DataService : ISprint1Task6V6
    {
        public string DeleteFirstLetter(string value)
        {
            string result = "";
            foreach (string word in value.Split())
            {
                if (word.Length > 0)
                {
                    result += word.Substring(1) + " ";
                }

            }
            result = result.Trim();
            return result;
        }
    }
}
