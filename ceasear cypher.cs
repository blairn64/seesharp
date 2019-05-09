using System;
using System.IO;

public class shifting_letters
{
    static string Caesar(string value, int shift)
    {
        char[] foo = value.ToCharArray();
        for (int i = 0; i < foo.Length; i++)
        {
            char letter = foo[i];
            
            letter = (char)(letter + shift);
            
            if (letter > 'z')
            {
                letter = (char)(letter - 26);
            }
            else if (letter < 'a')
            {
                letter = (char)(letter + 26);
            }
            


            foo[i] = letter;
        }
        return new string(foo);
    }

    static void Main()
    {
        string a = "ceaser cypher";
        string b = Caesar(a, -1);
        string c = Caesar("exxegoexsrgi", -4); 

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

        Console.ReadLine();
    }
}
   