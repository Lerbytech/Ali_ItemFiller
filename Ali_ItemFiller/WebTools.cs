using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Ali_ItemFiller
{
  public static class WebTools
  {

    public static string GetPageSourceCode(string Url)
    {
      HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
      HttpWebResponse response = (HttpWebResponse)request.GetResponse();

      string data = String.Empty;
      if (response.StatusCode == HttpStatusCode.OK)
      {
        Stream receiveStream = response.GetResponseStream();
        StreamReader readStream = null;

        if (response.CharacterSet == null)
        {
          readStream = new StreamReader(receiveStream);
        }
        else
        {
          readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
        }

        data = readStream.ReadToEnd();

        response.Close();
        readStream.Close();
      }

      return data;
    }

  }
}
