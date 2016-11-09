using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ali_ItemFiller
{
  public partial class Form1 : Form
  {
    CSinglePageParser SingleParser;
    CManyPageParser ManyParser;
    List<string> Sellers;
    List<ItemCard> Cards;
    ItemCard curCard;

    int _current_seller;
    int TotalSellers;
    int CurrentSeller
    {
      get
      {
          return _current_seller;
      }
      set
      {
        _current_seller = value;
        LBL_SellersCount.Text = _current_seller.ToString() + " / " + TotalSellers.ToString(); 
      }
    }
    bool doAddSeller;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      SingleParser = new CSinglePageParser();
      ManyParser = new CManyPageParser();

      Sellers = new List<string>();
      //CTestParser TP = new CTestParser();
      doAddSeller = false;
      
      TotalSellers = 0;
      CurrentSeller = 0; 
    }

    // bnt_parse
    private void button1_Click(object sender, EventArgs e)
    {
      Cards = ManyParser.Parse(TB_ManyPage.Text);
      TotalSellers = Cards.Count;
      
      CurrentSeller = 0;
      curCard = Cards[0];

      ShowSeller(CurrentSeller);
    }

    private void Process(ItemCard I)
    {
      SingleParser.Process(I.url);
    }

    /// <summary>
    ///  метод для получения картинки товара
    /// </summary>
    /// <param name="id"></param>
    private void ShowSeller(int id)
    {

    }
    private void Fill_TB_Properties(List<string> input)
    {
      foreach (var I in input)
      {
        if (TB_Properties.Text.Length == 0)
          TB_Properties.Text = I;
        else
          TB_Properties.AppendText("\r\n" + I);
      }
    }

    private void Fill_TB_Sellers(string s)
    {
      if (TB_Seller.Text.Length == 0)
        TB_Sellers.Text = s;
      else
        TB_Sellers.AppendText("\r\n" + s);
    }

    private void BTN_AddSeller_Click(object sender, EventArgs e)
    {
      SingleParser.Process(curCard.url);
      
      Fill_TB_Sellers(SingleParser.GetSeller());
      Process(curCard);

      Fill_TB_Properties(SingleParser.GetDescriptionOfProperties());
      Fill_TB_Sellers(SingleParser.GetSeller());
      TB_ItemName.Text = SingleParser.GetItemName();
    }

    private void BTN_SkipSeller_Click(object sender, EventArgs e)
    {

    }
  }
}
