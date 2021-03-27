using System;
using System.Text.RegularExpressions;

///<summary>
/// Quitar las vocales usando expresiones regulares
///</summary>

public static class Kata
{
    public static string Disemvowel(string str)
    {
        return Regex.Replace(str,"[aeiou]", "", RegexOptions.IgnoreCase);
    }
}