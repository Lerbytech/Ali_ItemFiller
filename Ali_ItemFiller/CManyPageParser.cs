using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali_ItemFiller
{
  public class CManyPageParser
  {
    public CManyPageParser()
    {

    }

    public List<ItemCard> Parse(string httpAdr)
    {
      string S = WebTools.GetPageSourceCode(httpAdr);
      List<string> ItemChunks = SplitSourcePage(S);
      List<ItemCard> ItemCards = FillItemCards(ItemChunks);
      
      return ItemCards;
    }

    private List<string> SplitSourcePage(string S)
    {
      string separator = "history-item product";
      //разобьем на отдельные строки. в каждой строке - своё свойство товара
      List<string> property_strings = S.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries).ToList();

      //избавляемся от 0 строки, которая не нужна
      property_strings.RemoveAt(0);

      // обрезаем последнюю строку
      string temp = property_strings[ property_strings.Count - 1];
      temp = temp.Substring(0, temp.IndexOf("<textarea"));
      property_strings[property_strings.Count - 1] = temp;

      return property_strings;
    }

    private List<ItemCard> FillItemCards(List<string> Chunks)
    {
      ItemCard tempCard = new ItemCard();
      List<ItemCard> res = new List<ItemCard>();
      for (int i = 0; i < Chunks.Count; i++)
      {
        tempCard.ID = GetID(Chunks[i]);
        tempCard.url = GetUrl(Chunks[i]);
        tempCard.seller_name = GetSellerName(Chunks[i]);
        tempCard.seller_url = GetSellerUrl(Chunks[i]);
        tempCard.orders = GetOrdersCount(Chunks[i]);
        tempCard.stats = new Dictionary<string, string>();
        tempCard.img_url = GetImageUrl(Chunks[i]);
        res.Add(tempCard);
      }

      res = res.OrderByDescending(t => t.orders).ToList();

      return res;
    }


    private long GetID(string s)
    {
      string res;

      string SearchPoint = @"data-id1=""";
      res = s.Substring( s.IndexOf(SearchPoint) + SearchPoint.Length);
      res = res.Substring(0, res.IndexOf('"'));
      return Convert.ToInt64(res);
    }

    private string GetUrl(string s)
    {
      string res = null;

      string LeftSearchPoint = @"ru.aliexpress.com/item/";
      string RightSearchPoint = @".html";

      res = s.Substring(s.IndexOf(LeftSearchPoint));
      res = res.Substring(0, res.IndexOf(RightSearchPoint) + RightSearchPoint.Length );

      return res;
    }
    private string GetSellerName(string s)
    {
      string res = null;
        string LeftSearchPoint = @"a href=""//ru.aliexpress.com/store/";

      res = s.Substring(s.IndexOf(LeftSearchPoint) + 10);

      res = res.Substring(0,  res.IndexOf(' ') - 1);
      return res;
    }
    private string GetSellerUrl(string s)
    {
      string res = null;

      string LeftSearchPoint = GetSellerName(s);
      res = s.Substring(s.IndexOf(LeftSearchPoint) + LeftSearchPoint.Length);

      res = res.Substring( res.IndexOf('>') + 1);
      res = res.Substring(0, res.IndexOf('<'));
      return res;
    }
    private string GetImageUrl(string s)
    {
      string res = null;
      string RightSearchPoint = @".jpg""";
      int RightIndex = s.LastIndexOf(RightSearchPoint);
      
      res = s.Substring(0, RightIndex + RightSearchPoint.Length - 1);

      string LeftSearchPoint = @"https://";
      int LeftIndex = s.LastIndexOf(LeftSearchPoint);
      res = res.Substring(LeftIndex);
      return res;
    }

    private int GetOrdersCount(string s)
    {
      string res = null;


      string LeftSearchPoint = @"Всего заказов""> ";
      res = s.Substring(s.IndexOf(LeftSearchPoint) + LeftSearchPoint.Length);

      res = res.Substring(0, res.IndexOf('<'));
      res = res.Substring(res.IndexOf('(') + 1);
      res = res.Substring(0, res.IndexOf(')'));

      return Convert.ToInt32(res);
    }
  }
}
