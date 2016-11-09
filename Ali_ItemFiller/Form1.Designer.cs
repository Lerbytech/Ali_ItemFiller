namespace Ali_ItemFiller
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.TB_ManyPage = new System.Windows.Forms.TextBox();
      this.BTN_Parse = new System.Windows.Forms.Button();
      this.TB_Properties = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.TB_Sellers = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.TB_Seller = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.BTN_AddSeller = new System.Windows.Forms.Button();
      this.TB_ItemName = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.BTN_SkipSeller = new System.Windows.Forms.Button();
      this.pictureBox = new System.Windows.Forms.PictureBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.LBL_SellersCount = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // TB_ManyPage
      // 
      this.TB_ManyPage.Location = new System.Drawing.Point(71, 9);
      this.TB_ManyPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.TB_ManyPage.Name = "TB_ManyPage";
      this.TB_ManyPage.Size = new System.Drawing.Size(927, 20);
      this.TB_ManyPage.TabIndex = 0;
      // 
      // BTN_Parse
      // 
      this.BTN_Parse.Location = new System.Drawing.Point(1015, 3);
      this.BTN_Parse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.BTN_Parse.Name = "BTN_Parse";
      this.BTN_Parse.Size = new System.Drawing.Size(66, 30);
      this.BTN_Parse.TabIndex = 1;
      this.BTN_Parse.Text = "Парсинг";
      this.BTN_Parse.UseVisualStyleBackColor = true;
      this.BTN_Parse.Click += new System.EventHandler(this.button1_Click);
      // 
      // TB_Properties
      // 
      this.TB_Properties.Location = new System.Drawing.Point(11, 150);
      this.TB_Properties.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.TB_Properties.Multiline = true;
      this.TB_Properties.Name = "TB_Properties";
      this.TB_Properties.Size = new System.Drawing.Size(496, 910);
      this.TB_Properties.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(20, 11);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Выдача:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(9, 133);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(58, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Свойства:";
      // 
      // TB_Sellers
      // 
      this.TB_Sellers.Location = new System.Drawing.Point(511, 150);
      this.TB_Sellers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.TB_Sellers.Multiline = true;
      this.TB_Sellers.Name = "TB_Sellers";
      this.TB_Sellers.Size = new System.Drawing.Size(398, 910);
      this.TB_Sellers.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(509, 133);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(62, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Продавцы:";
      // 
      // TB_Seller
      // 
      this.TB_Seller.Location = new System.Drawing.Point(71, 40);
      this.TB_Seller.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.TB_Seller.Name = "TB_Seller";
      this.TB_Seller.Size = new System.Drawing.Size(927, 20);
      this.TB_Seller.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(9, 40);
      this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(60, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Продаван:";
      // 
      // BTN_AddSeller
      // 
      this.BTN_AddSeller.Location = new System.Drawing.Point(937, 609);
      this.BTN_AddSeller.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.BTN_AddSeller.Name = "BTN_AddSeller";
      this.BTN_AddSeller.Size = new System.Drawing.Size(117, 30);
      this.BTN_AddSeller.TabIndex = 9;
      this.BTN_AddSeller.Text = "Добавить продавца";
      this.BTN_AddSeller.UseVisualStyleBackColor = true;
      this.BTN_AddSeller.Click += new System.EventHandler(this.BTN_AddSeller_Click);
      // 
      // TB_ItemName
      // 
      this.TB_ItemName.Location = new System.Drawing.Point(159, 68);
      this.TB_ItemName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.TB_ItemName.Name = "TB_ItemName";
      this.TB_ItemName.Size = new System.Drawing.Size(1242, 20);
      this.TB_ItemName.TabIndex = 10;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(11, 71);
      this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(144, 13);
      this.label5.TabIndex = 11;
      this.label5.Text = "Конечное название товара";
      // 
      // BTN_SkipSeller
      // 
      this.BTN_SkipSeller.Location = new System.Drawing.Point(1059, 609);
      this.BTN_SkipSeller.Name = "BTN_SkipSeller";
      this.BTN_SkipSeller.Size = new System.Drawing.Size(117, 30);
      this.BTN_SkipSeller.TabIndex = 12;
      this.BTN_SkipSeller.Text = "Пропустить";
      this.BTN_SkipSeller.UseVisualStyleBackColor = true;
      this.BTN_SkipSeller.Click += new System.EventHandler(this.BTN_SkipSeller_Click);
      // 
      // pictureBox
      // 
      this.pictureBox.Location = new System.Drawing.Point(937, 150);
      this.pictureBox.Name = "pictureBox";
      this.pictureBox.Size = new System.Drawing.Size(464, 425);
      this.pictureBox.TabIndex = 13;
      this.pictureBox.TabStop = false;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(159, 99);
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new System.Drawing.Size(1242, 20);
      this.textBox1.TabIndex = 14;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(7, 99);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(146, 13);
      this.label6.TabIndex = 15;
      this.label6.Text = "Название текущего товара";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(1122, 19);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(66, 13);
      this.label7.TabIndex = 16;
      this.label7.Text = "Продавцов:";
      // 
      // LBL_SellersCount
      // 
      this.LBL_SellersCount.AutoSize = true;
      this.LBL_SellersCount.Location = new System.Drawing.Point(1195, 19);
      this.LBL_SellersCount.Name = "LBL_SellersCount";
      this.LBL_SellersCount.Size = new System.Drawing.Size(0, 13);
      this.LBL_SellersCount.TabIndex = 17;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1430, 1095);
      this.Controls.Add(this.LBL_SellersCount);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.pictureBox);
      this.Controls.Add(this.BTN_SkipSeller);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.TB_ItemName);
      this.Controls.Add(this.BTN_AddSeller);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.TB_Seller);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.TB_Sellers);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.TB_Properties);
      this.Controls.Add(this.BTN_Parse);
      this.Controls.Add(this.TB_ManyPage);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox TB_ManyPage;
    private System.Windows.Forms.Button BTN_Parse;
    private System.Windows.Forms.TextBox TB_Properties;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox TB_Sellers;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox TB_Seller;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button BTN_AddSeller;
    private System.Windows.Forms.TextBox TB_ItemName;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button BTN_SkipSeller;
    private System.Windows.Forms.PictureBox pictureBox;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label LBL_SellersCount;
  }
}

