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
    //List<string> Sellers;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      SingleParser = new CSinglePageParser();
      ManyParser = new CManyPageParser();

      ManyParser.Parse(@"https://ru.aliexpress.com/af/umi-london.html?ltype=wholesale&d=y&origin=n&isViewCP=y&spm=2114.30010708.0.0.WtIzj6&site=rus&isrefine=y&SearchText=umi+london&CatId=202001195&initiative_id=AS_20161106002100&isAffiliate=y&isBrandWall=y&pvId=2-200005307&blanktest=0");

      //Sellers = new List<string>();
      CTestParser TP = new CTestParser();

    }

    private void button1_Click(object sender, EventArgs e)
    {
      SingleParser.Process(TB_ManyPage.Text);
      Fill_TB_Properties(SingleParser.GetDescriptionOfProperties());
      Fill_TB_Sellers(SingleParser.GetSeller());
      TB_ItemName.Text = SingleParser.GetItemName();
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
      SingleParser.Process(TB_Seller.Text);
      Fill_TB_Sellers(SingleParser.GetSeller());
    }
  }
}
