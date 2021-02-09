
namespace FormUI.Modules
{
    partial class SellingProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateBtn = new System.Windows.Forms.Button();
            this.TotalPriceTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UnitPriceTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StoreList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductList = new System.Windows.Forms.ComboBox();
            this.PieeceNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PieeceNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(556, 27);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(156, 72);
            this.CreateBtn.TabIndex = 30;
            this.CreateBtn.Text = "Ürün Sat";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // TotalPriceTxt
            // 
            this.TotalPriceTxt.Enabled = false;
            this.TotalPriceTxt.Location = new System.Drawing.Point(366, 76);
            this.TotalPriceTxt.Name = "TotalPriceTxt";
            this.TotalPriceTxt.Size = new System.Drawing.Size(170, 23);
            this.TotalPriceTxt.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Toplam Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Birim Fiyatı";
            // 
            // UnitPriceTxt
            // 
            this.UnitPriceTxt.Location = new System.Drawing.Point(12, 76);
            this.UnitPriceTxt.Name = "UnitPriceTxt";
            this.UnitPriceTxt.Size = new System.Drawing.Size(170, 23);
            this.UnitPriceTxt.TabIndex = 24;
            this.UnitPriceTxt.Text = "1";
            this.UnitPriceTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UnitPriceTxt_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Depo";
            // 
            // StoreList
            // 
            this.StoreList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoreList.FormattingEnabled = true;
            this.StoreList.Location = new System.Drawing.Point(366, 27);
            this.StoreList.Name = "StoreList";
            this.StoreList.Size = new System.Drawing.Size(170, 23);
            this.StoreList.TabIndex = 22;
            this.StoreList.SelectedIndexChanged += new System.EventHandler(this.StoreList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Müşteri";
            // 
            // CustomerList
            // 
            this.CustomerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerList.FormattingEnabled = true;
            this.CustomerList.Location = new System.Drawing.Point(12, 27);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(170, 23);
            this.CustomerList.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ürün";
            // 
            // ProductList
            // 
            this.ProductList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductList.FormattingEnabled = true;
            this.ProductList.Location = new System.Drawing.Point(189, 27);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(170, 23);
            this.ProductList.TabIndex = 18;
            this.ProductList.SelectedIndexChanged += new System.EventHandler(this.ProductList_SelectedIndexChanged);
            // 
            // PieeceNumber
            // 
            this.PieeceNumber.Location = new System.Drawing.Point(190, 76);
            this.PieeceNumber.Name = "PieeceNumber";
            this.PieeceNumber.Size = new System.Drawing.Size(169, 23);
            this.PieeceNumber.TabIndex = 31;
            this.PieeceNumber.Click += new System.EventHandler(this.PieeceNumber_Click);
            this.PieeceNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PieeceNumber_KeyUp);
            // 
            // SellingProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 115);
            this.Controls.Add(this.PieeceNumber);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.TotalPriceTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UnitPriceTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StoreList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductList);
            this.Name = "SellingProduct";
            this.Text = "SellingProduct";
            this.Load += new System.EventHandler(this.SellingProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PieeceNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.TextBox TotalPriceTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UnitPriceTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox StoreList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CustomerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProductList;
        private System.Windows.Forms.NumericUpDown PieeceNumber;
    }
}