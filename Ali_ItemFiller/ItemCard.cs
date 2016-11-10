using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali_ItemFiller
{
  public struct ItemCard
  {
    public long ID; // 1000003457007
    public string url; // https://ru.aliexpress.com/item/Original-Rugged-Anti-Fall-Umi-London-Mobile-Phone-3G-WCDMA-1GB-8GB-8MP-5-0-inch/1000003457007.html
    public string seller_url; // https://ru.aliexpress.com/store/2232044
    public string seller_name; //"86Prime Mobile Phone store
    public int orders; // число заказов
    public string img_url;

    public Dictionary<string, string> stats; // тривиально

  }
}
