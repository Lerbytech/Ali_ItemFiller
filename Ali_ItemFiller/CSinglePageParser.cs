using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ali_ItemFiller
{
  public class CSinglePageParser
  {
    private Dictionary<string, string> Properties;
    private string AliStyleItemName;
    private string Seller;

    public CSinglePageParser()
    {
      Properties = new Dictionary<string, string>();
    }
    public void Process(string pageUrl)
    {
      string htmlCode;

      //скачиваем код странички с учётом кодировки
      htmlCode = WebTools.GetPageSourceCode(pageUrl);

      //дополнительные поля
      AliStyleItemName = ParseItemName(htmlCode);
      Seller = ParseSeller(htmlCode);

      //свойства товара
      string ItemProperties_singlestring;
      ItemProperties_singlestring = CutItemProperties(htmlCode);

      //разбиваем большую строку на маленькие
      List<string> ItemProperties_string = SplitSingleString(ItemProperties_singlestring);

      //получаем словарь свойство-значение
      Dictionary<string, string> DirtyPropertyDescriptions = GetPropertyDescriptions(ItemProperties_string);

      //фильтруем ненужные поля - здесь можно настроить автозамены и прочее
      Properties = Filter(DirtyPropertyDescriptions);

      //List<string> del = GetDescriptionOfProperties();
    }
    public List<string> GetDescriptionOfProperties()
    {
      List<string> res = new List<string>();
      string temp = String.Empty;
      foreach (var I in Properties)
      {
        temp = String.Empty;
        temp += I.Key + " " + I.Value;
        res.Add(temp);
      }

      return res;
    }

    public string GetItemName()
    {
      return AliStyleItemName;
    }

    public string GetSeller()
    {
      return Seller;
    }

    #region Функции обработки строки

    /// <summary>
    /// Парсит название товара в стиле али
    /// </summary>
    /// <param name="input">исходный код всей страницы</param>
    /// <returns>строка с названим товара</returns>
    private string ParseItemName(string input)
    {
      string res;
      res = input;
      res = res.Substring( input.IndexOf("&nbsp;") + 6);
      res = res.Substring(0, res.IndexOf("&nbsp;"));

      return res;
    }

    private string ParseSeller(string input)
    {
      string res;
      string separator = @"www.aliexpress.com/store/";
      res = input.Substring(input.IndexOf(separator) + separator.Length);// input.IndexOf('"', input.IndexOf(separator)));
      res = res.Substring(0, res.IndexOf('"'));
      res = separator + res;
      return res;
    }
    


    /// <summary>
    /// Фукнция фильтрации значений - выкидывает мусор. Можно добавить автозамену по желанию
    /// </summary>
    /// <param name="input">плохой словарь</param>
    /// <returns>исправленый словарь</returns>
    private Dictionary<string, string> Filter(Dictionary<string, string>  input)
    {
      Dictionary<string, string> res = new Dictionary<string, string>();

      bool doCopy;
      string tempKey;
      foreach (var I in input)
      {
        doCopy = true;
        switch ( I.Key)
        {
          case "Google играть:": doCopy = false; break;
          case "Язык:": doCopy = false; break;
          case "Особенности:": doCopy = false; break;
          case "Цвет дисплея:": doCopy = false; break;
        }

        if (doCopy) res.Add(I.Key, I.Value);
      }

      return res;
    }

    /// <summary>
    /// обрезает всю страницу и вытаскивает только кусок с свойствами
    /// </summary>
    /// <param name="input">весь код страницы</param>
    /// <returns>строка с свойствами</returns>
    private string CutItemProperties(string input)
    {
      string res = String.Empty;


      string IntroPoint = "product-property-list util-clearfix";
       
      string LeftPropertySeparator = "property-item";
      string RightPropertySeparator = "<// li >";

      //Отбросили мусор до блока свойств
      res = input.Substring(input.IndexOf(IntroPoint) + IntroPoint.Length + 19); //ненужный шаг, но перестрахуемся

      //отбрасываем хвост
      int TailBegIndex = res.IndexOf("li>", res.LastIndexOf(LeftPropertySeparator));
      res = res.Substring(0, TailBegIndex -  4);

      return res;
    }
    /// <summary>
    /// разбивка блока с свойствами на отдельные строки
    /// </summary>
    /// <param name="input">большая строка</param>
    /// <returns>строки. каждая содержит своё свойство</returns>
    private List<string> SplitSingleString(string input)
    {
      string separator = "property-item";
      //разобьем на отдельные строки. в каждой строке - своё свойство товара
      string[] property_strings = input.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries);

      for (int i = 0; i < property_strings.Length; i++)
      {
        property_strings[i] = property_strings[i].Substring(0, property_strings[i].LastIndexOf("span>") + 5);


      }

      return property_strings.ToList();
    }

    /// <summary>
    /// финальный этап парсинга - получаем словарь свойства: название - значение
    /// </summary>
    /// <param name="input">список строк для обработки </param>
    /// <returns>словарь (содержит ВСЕ найденные свойства)</returns>
    private Dictionary<string, string> GetPropertyDescriptions(List<string> input)
    {
      Dictionary<string, string> res = new Dictionary<string, string>();
      List<string> temp;
      string prop_title;
      string prop_val;

      for (int i = 0; i < input.Count; i++)
      {
        temp = input[i].Split(new string[] { "<span class=" }, StringSplitOptions.RemoveEmptyEntries).ToList();

        if (temp.Count != 3) throw new Exception("ERROR in parsing property vals");

        prop_title = temp[1].Substring(temp[1].IndexOf('>') + 1);
        prop_val = temp[2].Substring(temp[2].IndexOf('>') + 1);

        prop_title = prop_title.Substring(0, prop_title.IndexOf('<'));
        prop_val = prop_val.Substring(0, prop_val.IndexOf('<'));

        res.Add(prop_title, prop_val);
      }
      return res;
    }

    #endregion



  }
}
