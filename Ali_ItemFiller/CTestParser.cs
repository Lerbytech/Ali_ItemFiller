using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ali_ItemFiller
{
  public class CTestParser
  {
    public CTestParser()
    {
      List<string> SS = new List<string>();
      SS = LoadRawString();
      SS = RawFilter(SS);


    }

    public List<string> LoadRawString()
    {
      return File.ReadAllLines(@"C:\Users\Админ\Desktop\UmiPhones.txt").ToList();
    }

    public List<string> RawFilter(List<string> input)
    {
      List<string> res = new List<string>();
      for (int i = 0; i < input.Count; i++)
        if (input[i].Contains(@"https://ru.aliexpress.com/item/"))
          res.Add(input[i]);

      for (int i = 0; i < res.Count; i++)
      {
        res[i] = res[i].Substring(@"https://ru.aliexpress.com/item/".Length);

      }

      for (int i = 0; i < res.Count; i++)
      {
        res[i] = res[i].Substring(0, res[i].IndexOf('/'));

      }

      List<string> s2 = new List<string>();
      List<string> temp = new List<string>();
      for (int i = 0; i < res.Count; i++)
      {
        temp = res[i].Split(new char[] { '-' }).ToList();

        for (int j = 0; j < temp.Count; j++)
          if (!s2.Contains(temp[j])) 
            s2.Add(temp[j]);
        //s2.AddRange(res[i].Split(new char[] { '-' }));
      }

      

      return res;

    }

  }
}
