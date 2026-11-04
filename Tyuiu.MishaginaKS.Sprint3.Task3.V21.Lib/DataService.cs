namespace Tyuiu.MishaginaKS.Sprint3.Task3.V21.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;

public class DataService : ISprint3Task3V21

{
    public string ReplaceNumOnChar(string value, char item)

    {
        {
            string result = "";

            foreach (char ch in value)

            {
                if (Char.IsDigit(ch))
                {
                    result += item;
                }
                else
                {
                    result += ch;
                }
            }

            return result;
        }
    }
} 
    

