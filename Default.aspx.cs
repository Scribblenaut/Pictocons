using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Drawing;

public partial class _Default : Instructions
{
    string path = "~/Resources/Copy of Resources.xml";
    List<int> numbers = new List<int>();
    List<string> chosen = new List<string>();
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        //lable.Text = Choose(Text.Text,ParseInfo());
        //ParseInfo();
        NumberOfSeeds();
        //TODO: Catch an error if string s has less characters than numbers.count
        Choose(Splice("123456789",("123456789").Count()/numbers.Count));
        //string result = Crypt(Text.Text);
        //string divided = "";
        //int index = 0;
        //foreach (char c in result)
        //{
        //    index++;
        //    if (index % 16 == 0)
        //    {
        //        divided += c + " | ";
        //    }
        //    else
        //    {
        //        divided += c;
        //    }

        //}
        //lable.Text = divided;
        //number.Text = result.Count().ToString();
    }
    public void Choose(List<int> Spliced)
    {
        numbers[2] = numbers[2] - 1;
        int counter = 0;
        foreach (int interger in numbers)
        {
            counter++;
            Random random = new Random(Spliced[counter]);
            
            chosen.Add(GetXMLNode(random.Next(interger)));
        }
        //XmlDocument document = new XmlDocument();
        //document.Load(MapPath(path));
        //XmlNodeList nodelist = document.SelectNodes("//*");
        //bool more = true;
        //while (more)
        //{
            
        //    break;
        //}

    }
    public string GetXMLNode(int i)
    {
        string result = "";

        return result;
    }
    public void NumberOfSeeds()
    {
        XmlReader reader = XmlReader.Create(MapPath(path));
        while (reader.Read())
        {
            if (reader.IsStartElement())
            {
                if (numbers.Count > reader.Depth)//& reader.Depth != 0)
                {
                    numbers[reader.Depth] = numbers[reader.Depth] + 1;//reader.Depth;
                }
                else
                {
                    numbers.Add(1);//reader.Depth);
                }
            }
        }
    }

    //public List<List<KeyValuePair<string, string>>> ParseInfo()
    //{
    //    List<List<KeyValuePair<string, string>>> Data = new List<List<KeyValuePair<string, string>>>();
    //    XmlDocument document = new XmlDocument();
    //    document.Load(MapPath(path));
    //    XmlNodeList nodelist = document.SelectNodes("Template/Animal");
    //    foreach(XmlNode nodes in nodelist)
    //    {
    //        if (nodes.HasChildNodes)
    //        {
    //            foreach (XmlNode node in nodes.ChildNodes)
    //            {
    //                foreach (XmlNode nod in node.ChildNodes)
    //                {
    //                    Console.WriteLine(nod.InnerText);
    //                }
    //            }
    //        }
    //    }
    //    return Data;
    //}
    public System.Drawing.Image MergeImages(List<System.Drawing.Image> Images)
    {
        Point point = new Point(0,0);
        System.Drawing.Image FinalImage = null;
        foreach (System.Drawing.Image image in Images)
        {
            using (Graphics graphics = Graphics.FromImage(image))
            {
                graphics.DrawImage(FinalImage, point);
            }
        }
        return FinalImage;
    }

}
