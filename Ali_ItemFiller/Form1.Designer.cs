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
      this.SuspendLayout();
      // 
      // TB_ManyPage
      // 
      this.TB_ManyPage.Location = new System.Drawing.Point(95, 11);
      this.TB_ManyPage.Name = "TB_ManyPage";
      this.TB_ManyPage.Size = new System.Drawing.Size(1046, 22);
      this.TB_ManyPage.TabIndex = 0;
      // 
      // BTN_Parse
      // 
      this.BTN_Parse.Location = new System.Drawing.Point(95, 77);
      this.BTN_Parse.Name = "BTN_Parse";
      this.BTN_Parse.Size = new System.Drawing.Size(88, 37);
      this.BTN_Parse.TabIndex = 1;
      this.BTN_Parse.Text = "Парсинг";
      this.BTN_Parse.UseVisualStyleBackColor = true;
      this.BTN_Parse.Click += new System.EventHandler(this.button1_Click);
      // 
      // TB_Properties
      // 
      this.TB_Properties.Location = new System.Drawing.Point(15, 184);
      this.TB_Properties.Multiline = true;
      this.TB_Properties.Name = "TB_Properties";
      this.TB_Properties.Size = new System.Drawing.Size(530, 371);
      this.TB_Properties.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(26, 14);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(63, 17);
      this.label1.TabIndex = 3;
      this.label1.Text = "Выдача:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 164);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(73, 17);
      this.label2.TabIndex = 4;
      this.label2.Text = "Свойства:";
      // 
      // TB_Sellers
      // 
      this.TB_Sellers.Location = new System.Drawing.Point(565, 184);
      this.TB_Sellers.Multiline = true;
      this.TB_Sellers.Name = "TB_Sellers";
      this.TB_Sellers.Size = new System.Drawing.Size(530, 371);
      this.TB_Sellers.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(562, 164);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(79, 17);
      this.label3.TabIndex = 6;
      this.label3.Text = "Продавцы:";
      // 
      // TB_Seller
      // 
      this.TB_Seller.Location = new System.Drawing.Point(95, 49);
      this.TB_Seller.Name = "TB_Seller";
      this.TB_Seller.Size = new System.Drawing.Size(1046, 22);
      this.TB_Seller.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 49);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(77, 17);
      this.label4.TabIndex = 8;
      this.label4.Text = "Продаван:";
      // 
      // BTN_AddSeller
      // 
      this.BTN_AddSeller.Location = new System.Drawing.Point(250, 77);
      this.BTN_AddSeller.Name = "BTN_AddSeller";
      this.BTN_AddSeller.Size = new System.Drawing.Size(156, 37);
      this.BTN_AddSeller.TabIndex = 9;
      this.BTN_AddSeller.Text = "Добавить продавца";
      this.BTN_AddSeller.UseVisualStyleBackColor = true;
      this.BTN_AddSeller.Click += new System.EventHandler(this.BTN_AddSeller_Click);
      // 
      // TB_ItemName
      // 
      this.TB_ItemName.Location = new System.Drawing.Point(506, 114);
      this.TB_ItemName.Name = "TB_ItemName";
      this.TB_ItemName.Size = new System.Drawing.Size(822, 22);
      this.TB_ItemName.TabIndex = 10;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(506, 91);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(122, 17);
      this.label5.TabIndex = 11;
      this.label5.Text = "Название товара";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1361, 567);
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
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
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
  }
}

