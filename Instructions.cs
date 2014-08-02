using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Generates a Kawaiicon
/// </summary>
public class Instructions : System.Web.UI.Page
{
    //List<string> Eyes = new List<string>(){ "Round", "Sparkly", "Evil", "Happy" };
    //List<string> Mouth = new List<string>() { "Happy", "Sad", "Neutral", "Open" };
    //List<string> Cheeks = new List<string>() { "Blush", "Normal", "Red", "Chubby" };
    //List<string> Body = new List<string>() { "Bunny", "Cat", "Blob", "Ugly Cupcake(Muffin)" };
    public Instructions()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public string Crypt(string s)
    {
        SHA1 sha = new SHA1Managed();
        byte[] hash = sha.ComputeHash(Encoding.ASCII.GetBytes(s));
        StringBuilder builder = new StringBuilder();
        foreach (byte b in hash)
        {
            builder.AppendFormat("{0:x2}", b);
        }
        return builder.ToString();
    }
    //public List<int> Choose(List<int> Spliced, List<int> Max)
    //{
    //    List<int> Chosen = new List<int>();
    //    int counter = 0;
    //    foreach (int i in Max)
    //    {
    //        counter++;
    //        Random random = new Random(Spliced[counter]);
    //        Chosen.Add(random.Next(Max[counter]));
    //    }
    //    return Chosen;
    //}
    public List<int> Splice(string s, int divider)
    {
        List<int> Pieces = new List<int>();
        int groupnumber = s.Length / divider;
        string origional = s;
        while (origional.Length > divider)
        {
            Pieces.Add(int.Parse(origional.Remove(0, origional.Length - divider)));
            origional = origional.Remove(origional.Length - divider, divider);
        }
        Pieces.Add(int.Parse(origional));
        return Pieces;
    }
    #region WorkingTest
    //public string Choose(string s, List<List<KeyValuePair<string,string>>> Catagories)
    //{
    //    string input =  Crypt(s);
    //    string result = "";
    //    foreach(char c in input)
    //    {
    //        if (char.IsLetter(c))
    //        {
    //            result += (char.ToUpper(c)-64);
    //        }
    //        else
    //        {
    //            result += c;
    //        }
    //    }
    //    //result = result.Remove(0,result.Length-9);
        
    //    //Random random = new Random(int.Parse(result));
    //    List<string> chosen = new List<string>();
    //    //chosen.Add(Eyes[random.Next(0, chosen.Count)]);
    //    //chosen.Add(Mouth[random.Next(0, chosen.Count)]);
    //    //chosen.Add(Cheeks[random.Next(0, chosen.Count)]);
    //    //chosen.Add(Body[random.Next(0, chosen.Count)]);
    //    List<int> pieces = new List<int>();
    //    int number = result.Length/Catagories.Count;
    //    string left = result;
    //    while (left.Length > number)
    //    {
    //        pieces.Add(int.Parse(left.Remove(left.Length - number, number)));
    //    }
    //    foreach (List<KeyValuePair<string,string>> C in Catagories)
    //    {
    //        foreach (KeyValuePair<string, string> K in C)
    //        {

    //        }
    //    }
    //    string strings = "";
    //    foreach (string a in chosen)
    //    {
    //        strings += a;
    //    }
    //    return strings;
    //}
    #endregion
    //public static int GetLevel(this XObject node)
    //{
    //    if (node.Parent == null) return 0;
    //    return 1 + node.Parent.GetLevel();
    //}
}
